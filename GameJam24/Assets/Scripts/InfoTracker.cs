using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoTracker : MonoBehaviour
{

    public static InfoTracker instance;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            transform.SetParent(null);

            DontDestroyOnLoad(gameObject);
                
            currentPoints = PlayerPrefs.GetInt("Points");
            
        }

        else
        {
            Destroy(gameObject);
        }
    }


    public int currentPoints;
    // Start is called before the first frame update
    public void getInfo()
    {
        if (CollectibleManager.instance != null)
        {
            currentPoints = CollectibleManager.instance.collectibleCount;
        }
    }
}
