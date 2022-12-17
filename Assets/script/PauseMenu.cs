using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;
    public GameObject SettingMenuUI;
    public AudioSource game_sound;
    public GameObject RestartMenuUI;
    public GameObject WinMenuUI;
    Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        game_sound.Pause();
    }



    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        game_sound.Play();
    }


    public void home()
    {   
        Time.timeScale = 1f;
        SceneManager.LoadScene("start_menu");
    }

    public void setting_panel()
    {
        SettingMenuUI.SetActive(true);
        PauseMenuUI.SetActive(false);

    }

    public void Restart_1()
    {
        RestartMenuUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("game_1");
    }

    public void Restart_2()
    {
        RestartMenuUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("game_2");
    }

    public void level_Win()
    {
        Time.timeScale = 1f;
        WinMenuUI.SetActive(false);
        SceneManager.LoadScene("game_2");
    }

}

