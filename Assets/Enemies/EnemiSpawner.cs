using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiSpawner : MonoBehaviour
{
    public GameObject EnemiSold;
    public Transform EnemispawnPoint;

    public float Health = 1500;

    [Header("Unity stuff")]
    public Image HealthBar;

    public void TakeDmg(float dmg)
    {
        Health -= dmg;

        HealthBar.fillAmount = Health / 1500f;

        if (Health <= 0)
        {
            Destroy(this.gameObject, 1);
            FindObjectOfType<MainMenu>().EndGame();

        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bullet")
        {

        }
        else if (col.gameObject.tag == "Player")
        {
            float dmg = 20;
            TakeDmg(dmg);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Spawn", 5, 1f);
        //Spawn();
        Invoke("Spawn", 5);
    }

    void Spawn()
    {
        Instantiate(EnemiSold, EnemispawnPoint.transform.position, EnemispawnPoint.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {


    }
}
