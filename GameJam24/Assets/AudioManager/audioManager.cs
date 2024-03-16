using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    //başka scriptlerde kullanma
    public static audioManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            //seviyede yoksa kur.
            SetupAudioManager();
        }
        else if(instance != this)
        {
            //varsa sil yenisini kur.
            Destroy(gameObject);
        }
    }

    public void SetupAudioManager()
    {
        instance = this; //caching
        DontDestroyOnLoad(gameObject);
    }


    //müzikleri seçme kısmı
    public AudioSource menuMusic, levelMusic;

    public AudioSource[] SFX; // sound effect array

    public void stopMusic()
    {
        //müzikler aynı anda çalmasın diye durdurma
        menuMusic.Stop();
        levelMusic.Stop();
    }

    public void MenuMusic()
    {
        stopMusic();
        menuMusic.Play();
    }

    public void LevelMusic()
    {
        stopMusic();
        levelMusic.Play();
    }

    public void sFX(int sfxPlay)
    {
        //sound effectlerin çalması
        SFX[sfxPlay].Stop();
        SFX[sfxPlay].Play();

    }
}
