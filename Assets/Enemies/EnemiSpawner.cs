using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiSpawner : MonoBehaviour
{
    public GameObject EnemiSold;
    public Transform EnemispawnPoint;

    public float Health = 500;
    float dmg;

    [Header("Unity stuff")]
    public Image HealthBar;

    public void TakeDmg()
    {
        dmg = 20;
        Health -= dmg;

        HealthBar.fillAmount = Health / 500f;

        if (Health <= 0)
        {
            Destroy(this.gameObject, 1);
            FindObjectOfType<MainMenu>().EndGame();

        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "arrow")
        {

        }
        else if (col.gameObject.tag == "Player")
        {
            // float dmg = 20;
            // TakeDmg(dmg);
            InvokeRepeating("TakeDmg", 1, 3f);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "arrow")
        {

        }
        else if (col.gameObject.tag == "Player")
        {
            // float dmg = 20;
            // TakeDmg(dmg);
            //InvokeRepeating("TakeDmg", 1, 3f);
            CancelInvoke("TakeDmg");
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 5, 10f);
        //Spawn();
        //Invoke("Spawn", 5);
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
