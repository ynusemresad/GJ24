using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class ButtonActions : MonoBehaviour
{
    private NetworkManager NetworkManager;
    void Start()
    {
        NetworkManager = GetComponent<NetworkManager>();
    }

    public void StartHost()
    {
        NetworkManager.StartHost();
    }

    public void StartClient()
    {
        NetworkManager.StartClient();
    }
}
