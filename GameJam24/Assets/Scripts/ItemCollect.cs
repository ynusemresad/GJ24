using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    bool parca1;
    bool parca2;
    bool parca3;

    private void Awake()
    {
        
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Debug.Log("Girildi.");

            if (other.gameObject.name == "parca1")
            {
                parca1 = true;
            }
            
            if (other.gameObject.name == "parca2")
            {
                parca2 = true;
            }
            
            if (other.gameObject.name == "parca3")
            {
                parca3 = true;
            }
            
            //Burada audio oynatabiliriz item toplanti vvfip diye bir ses fln
            Destroy(other.gameObject);
            
            Debug.Log(other.gameObject.name + "Alindi");

            
        }

        if (other.gameObject.CompareTag("Countertop"))
        {
            
        }
    }
}
