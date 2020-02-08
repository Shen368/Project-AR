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
        int price = 50;
        int pocket;
        pocket=FindObjectOfType<MainMenu>().nbCoin;
        if (price <= pocket)
        {
            Instantiate(sold, spawnPoint.transform.position, spawnPoint.transform.rotation);
            FindObjectOfType<MainMenu>().nbCoin -= price;

        }
        else
        {
            Debug.Log("Not enough Money!!");
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
