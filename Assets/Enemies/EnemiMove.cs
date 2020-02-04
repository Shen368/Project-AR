using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiMove : MonoBehaviour
{
    float speed = 0.02f;
    float turnSpeed = 2.0f;
    public bool dead = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bullet")
        {

        }
        else if (col.gameObject.tag == "userHome")
        {
            Destroy(this.gameObject, 1);

        }
        else if (col.gameObject.tag == "Player")
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
        GameObject userHome = GameObject.FindWithTag("userHome");
        if (userHome != null)
        {
            Vector3 direction = userHome.transform.position - this.transform.position;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), turnSpeed * Time.smoothDeltaTime);
        }
        this.transform.Translate(0, 0, speed);
    }
}
