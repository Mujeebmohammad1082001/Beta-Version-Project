using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio_manager : MonoBehaviour
{

    public Slider musicSlider;
    public Slider soundSlider;
    public AudioSource myMusic;

    // Start is called before the first frame update

    void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume"))
        {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        }

        else
        {
            musicSlider.value = 1;
        }

        if(PlayerPrefs.HasKey("soundVolume"))
        {
        soundSlider.value = PlayerPrefs.GetFloat("soundVolume");
        }

        else
        {
            soundSlider.value = 1;
        }
    }



    // Update is called once per frame
    void Update()
    {
        myMusic.volume = PlayerPrefs.GetFloat("musicVolume");


        PlayerPrefs.SetFloat("musicVolume", musicSlider.value);
        PlayerPrefs.SetFloat("soundVolume", soundSlider.value);

        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        soundSlider.value = PlayerPrefs.GetFloat("soundVolume");

        
    }
}
