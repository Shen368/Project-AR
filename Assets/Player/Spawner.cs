using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   
    public GameObject userHome;
    // Start is called before the first frame update
    void Start()
    {
      //  InvokeRepeating("Spawn", 0, 0.8f);
        Instantiate(userHome, this.transform.position, this.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
