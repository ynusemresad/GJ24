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


    //sayaç
    public GameObject TimeUI;
    public float timeValue;
    public TMP_Text timeText;


    //puzzle collectibles
    public TMP_Text collectibles; 




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //oyunu durdurma ve pause menüsüne girme.
            PauseNoPause();
        }
        //sayaç

        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            gameOver();
        }
        displayTime(timeValue);


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


    public void gameOver()
    {
        if(GameOverScreen != null)
        {
            TimeUI.SetActive(false);
            GameOverScreen.SetActive(true);
        }
    }

    //sayaç fonskiyonu

    public void displayTime(float timetoDisplay)
    {
        if (timetoDisplay < 0)
        {
            timetoDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timetoDisplay / 60);
        float seconds = Mathf.FloorToInt(timetoDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    //collectibles ui
    public void CollectiblesUpdate(int amount)
    {
        collectibles.text = amount.ToString();
    }

}
