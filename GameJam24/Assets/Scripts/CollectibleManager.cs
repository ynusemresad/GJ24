using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{

    public static CollectibleManager instance;

    private void Awake()
    {
        instance = this;
    }

    public int collectibleCount;
  

     
    // Start is called before the first frame update
    void Start()
    {
        collectibleCount = InfoTracker.instance.currentPoints;

        if(UI.instance != null)
        {
            UI.instance.CollectiblesUpdate(collectibleCount); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getCollectible(int amount)
    {
        collectibleCount += amount;
        if(UI.instance!= null)
        {
            UI.instance.CollectiblesUpdate(collectibleCount);
        }
    }
}
