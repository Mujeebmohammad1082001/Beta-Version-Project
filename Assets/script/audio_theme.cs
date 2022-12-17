using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_theme : MonoBehaviour
{
    public GameObject SettingMenuUI;
    public GameObject AudioMenuUI;
    public GameObject ThemeMenuUI;

    public void audio_back()
    {
        AudioMenuUI.SetActive(false);
        SettingMenuUI.SetActive(true);
    }

    public void theme_back()
    {
        ThemeMenuUI.SetActive(false);
        SettingMenuUI.SetActive(true);
    }
}
