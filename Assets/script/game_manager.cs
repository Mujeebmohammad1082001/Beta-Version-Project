using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class game_manager : MonoBehaviour
{
    public static int coinNum = 0;
    public static int jumpNum;
    Text coin_text;
    Text jump_text;
    private string sky_num;
    public Material day;
    public Material night;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("addJump" , 1);
        coin_text = GameObject.Find("coin_text").GetComponent<Text>();
        jump_text = GameObject.Find("jump_text").GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        sky_num = PlayerPrefs.GetString("sky_box");


        if(sky_num=="day")
        {
            RenderSettings.skybox=day;
        }

        else if(sky_num == "night")
        {
            RenderSettings.skybox=night;

        }
        else
        {
            Debug.Log("Something wrong");
        }

        coin_text.text = ": " + coinNum;
        jump_text.text = "JUMPS : " + jumpNum;    
    }

    void addJump()
    {
        jumpNum++;
        Invoke("addJump" , 10);
    }


}
