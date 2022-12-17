using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setting_panel : MonoBehaviour
{

    public GameObject PauseMenuUI;
    public GameObject ThemeMenuUI;
    public GameObject AudioMenuUI;
    public GameObject SettingMenuUI;


    public void Audio_panel()
    {
        AudioMenuUI.SetActive(true);
        SettingMenuUI.SetActive(false);
    }

        public void Theme_panel()
    {
        ThemeMenuUI.SetActive(true);
        SettingMenuUI.SetActive(false);
    }

    public void back()
    {
        PauseMenuUI.SetActive(true);
        SettingMenuUI.SetActive(false);
    }
}
