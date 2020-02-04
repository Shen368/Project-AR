using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiSpawner : MonoBehaviour
{
    public GameObject EnemiSold;
    public GameObject EnemiHome;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 1f);
        //Spawn();
        Instantiate(EnemiHome, this.transform.position, this.transform.rotation);
    }

    void Spawn()
    {
        Instantiate(EnemiSold, this.transform.position, this.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
