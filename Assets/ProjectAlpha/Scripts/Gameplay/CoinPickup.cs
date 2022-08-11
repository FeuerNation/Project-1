using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    public int Coins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.transform.tag =="Coin")
        {
            Destroy(other.gameObject);
            Coins++;
            print(Coins);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
