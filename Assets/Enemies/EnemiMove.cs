using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiMove : MonoBehaviour
{
    float speed = 0.02f;
    float turnSpeed = 3.0f;
    public float Health = 100;
    public bool dead = false;
    float dmg;

    [Header("Unity stuff")]
    public Image HealthBar;

    public void TakeDmg()
    {
        dmg = 20;
        Health -= dmg;

        HealthBar.fillAmount = Health / 100f;
        
        if (Health <= 0)
        {
            Destroy(this.gameObject, 1);
            FindObjectOfType<MainMenu>().nbCoin += 10;
        }
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "arrow")
        {

        }
        else if (col.gameObject.tag == "userHome")
        {
            //Destroy(this.gameObject, 1);
            speed = 0f;

        }
        else if (col.gameObject.tag == "Player")
        {
            speed = 0f;
            InvokeRepeating("TakeDmg", 1, 3f);
         //   TakeDmg(dmg);
        }
        else
        {
            speed = 0.02f;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "arrow")
        {

        }
        else if (col.gameObject.tag == "userHome")
        {
            //Destroy(this.gameObject, 1);
          //  speed = 0f;

        }
        else if (col.gameObject.tag == "Player")
        {
          //  speed = 0f;
            CancelInvoke("TakeDmg");
            //   TakeDmg(dmg);
        }
        else
        {
            speed = 0.02f;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dead) return;
        GameObject userHome = GameObject.FindWithTag("userHome");
        if (userHome != null)
        {
            Vector3 direction = userHome.transform.position - this.transform.position;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), turnSpeed * Time.smoothDeltaTime);
        }
        this.transform.Translate(0, 0, speed);
    }
}
