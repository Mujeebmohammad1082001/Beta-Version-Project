using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coins : MonoBehaviour
{
    public AudioClip coinSound;
    public int rotateSpeed;

    void Start() 
    {   
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {

        if(collision.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(coinSound, transform.position, PlayerPrefs.GetFloat("soundVolume"));
            game_manager.coinNum += 1;
            Destroy(this.gameObject);


            //GameHandler.numberofCoins++;

        }

    
    }
}
