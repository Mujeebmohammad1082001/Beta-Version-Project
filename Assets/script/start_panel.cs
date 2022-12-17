using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_panel : MonoBehaviour
{

    //for start button
    public void start()
    {
        SceneManager.LoadScene("game_1");
    }

    
    public void quit_game()
    {
        Application.Quit();
    }



}
