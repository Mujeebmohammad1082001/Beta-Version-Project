using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skybox : MonoBehaviour
{
    public Material day;
    public Material night;
    private string sky_num;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        sky_num = PlayerPrefs.GetString("sky_box");

        if(sky_num == "day")
        {
            RenderSettings.skybox = day;
        }

        else if(sky_num == "night")
        {
            RenderSettings.skybox = night;
        }      
    }

    public void day_skybox()
    {
        PlayerPrefs.SetString("sky_box", "day");

    }

    public void night_skybox()
    {
        PlayerPrefs.SetString("sky_box", "night");
    }
}
