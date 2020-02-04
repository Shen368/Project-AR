using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoc : MonoBehaviour
{
    public GameObject sold;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Spawn()
    {
        Instantiate(sold, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
