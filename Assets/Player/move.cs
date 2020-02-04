using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour
{
    float speed = 0.02f;
    float turnSpeed = 3.0f;
    public bool dead = false;

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
