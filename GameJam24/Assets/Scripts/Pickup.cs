using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int amount = 1;

    


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Character"))
        {
            if (CollectibleManager.instance != null)
            {
                CollectibleManager.instance.getCollectible(amount);

                Destroy(gameObject);

                

                
            }
        }
    }
}
