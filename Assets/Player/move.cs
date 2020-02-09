using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    Animator anim;
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
            CancelInvoke("TakeDmg");
        }
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "bullet")
        {
            
        }
        else if (col.gameObject.tag == "EnemiHome")
        {
            //Destroy(this.gameObject, 1);
            speed = 0f;
        }
        else if (col.gameObject.tag == "Enemie")
        {
            speed = 0f;
            
           // TakeDmg(dmg);
            InvokeRepeating("TakeDmg", 1, 3f);

        }
        else
        {
            speed = 0.02f;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dead) return;
        GameObject EnemiHome = GameObject.FindWithTag("EnemiHome");
        if(EnemiHome != null) //verifier si la maison de  enemie existe
        {
            //tourner vers la maison de enemie
            Vector3 direction = EnemiHome.transform.position - this.transform.position;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), turnSpeed * Time.smoothDeltaTime);
        }
        //avancer avec une vitesse pre-defini
        this.transform.Translate(0, 0, speed);
    }
}
