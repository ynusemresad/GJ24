using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    // UI elementleri tanımlama
    public GameObject GameOverScreen;

    public GameObject pauseScreen;

    public string mainMenuScene;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //oyunu durdurma ve pause menüsüne girme.
            PauseNoPause();
        }
        
    }






    public void PauseNoPause()
    {
        //oyun zamanını durdurma
        if(pauseScreen.activeSelf == false)
        {
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            //oyun zamanını geri açma
            pauseScreen.SetActive(false);
            Time.timeScale = 1f;
        }
    }


    public void mainMenu()
    {
        //ana menüye gitme
        SceneManager.LoadScene(mainMenuScene);
        Time.timeScale = 1f;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        Debug.Log("bölümü yeniden başlatıım.");
    }

    public void quitGame()
    {
        //oyundan çıkma.
        Application.Quit();
        Debug.Log("oyundan çıkıldı");
    }
}
