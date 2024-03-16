using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    //tanımlamalar
    public string firstLevel;

    void Start()
    {
        
    }



    public void startGame()
    {
        //ilk leveli açar.
        SceneManager.LoadScene(firstLevel);
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("oyundan çıktım.");
    }
}
