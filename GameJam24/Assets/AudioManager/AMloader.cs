using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMloader : MonoBehaviour
{
    //oyun başında her bölümde audiomanager çalışması için bu scripti yazdım.
    public audioManager theAM;

    private void Awake()
    {
        if(audioManager.instance == null)
        {
            Instantiate(theAM).SetupAudioManager();
        }
    }
}
