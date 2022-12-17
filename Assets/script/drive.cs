using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drive : MonoBehaviour
{
    public float forwardSpeed;
    public float up_Force;
    public float turnSpeed;
    public float rotateSpeed;
    
    public Rigidbody rb;
    public GameObject Player;
    public GameObject tyres, frontPart, backPart;


    public GameObject RestartMenuUI;
    public GameObject WinMenuUI;

    public AudioClip crashSound;
    public AudioClip jumpSound;
    public AudioSource game_sound;

    public GameObject explosion;
    
    // Start is called before the first frame update
    void Start()
    {
        game_manager.jumpNum *= 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        if(transform.position.x > 3)
        {
            transform.position = new Vector3(3f, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.identity;
        }

        else if(transform.position.x < -3)
        {
            transform.position = new Vector3(-3f, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.identity;
        }


        


        else if(Input.GetKey("right") && transform.position.x <= 3)
        {
            transform.Rotate(new Vector3(0, rotateSpeed, 0) * Time.deltaTime);
            transform.Translate (Vector3.right * turnSpeed * Time.deltaTime);
        
        }
        else if(Input.GetKey("left") && transform.position.x >= -3)
        {
            transform.Rotate(new Vector3(0, -rotateSpeed, 0) * Time.deltaTime);
            transform.Translate (Vector3.left * turnSpeed * Time.deltaTime);
        }

        else
        {
            if(transform.localRotation.y > 0)
            {
                transform.Rotate(new Vector3(0, -40, 0) * Time.deltaTime);
            }

            else if(transform.localRotation.y < 0)
            {
                transform.Rotate(new Vector3(0, 40, 0) * Time.deltaTime);
            }

            else
            {
                Debug.Log("fix position !!!");
            }
        }

        /*else if(Input.GetKey("left"));
        {
            transform.Translate (Vector3.left * turnSpeed * Time.deltaTime);

        }*/

        if(Input.GetKeyDown("up") && transform.position.y <= 11 && game_manager.jumpNum > 0 && Time.timeScale != 0)
        {

            rb.AddForce(0, up_Force, 0, ForceMode.Impulse);
            game_manager.jumpNum--;
            AudioSource.PlayClipAtPoint(jumpSound, transform.position, PlayerPrefs.GetFloat("soundVolume"));

        }

        if(Player.transform.position.y > 12)
            {
                tyres.transform.localScale = new Vector3(1.4f, 1, 1);
                frontPart.transform.localScale = new Vector3(1.4f, 1, 1);
                backPart.transform.localScale = new Vector3(1.4f, 1, 1);
            }

        else if(Player.transform.position.y < 11)
        {
            tyres.transform.localScale = new Vector3(1, 1, 1);
            frontPart.transform.localScale = new Vector3(1, 1, 1);
            backPart.transform.localScale = new Vector3(1, 1, 1);
        }


        
    }



    private void OnCollisionEnter(Collision collision) 
    {

    if(collision.gameObject.tag == "car")
        {
            game_sound.Pause();
            AudioSource.PlayClipAtPoint(crashSound, transform.position, PlayerPrefs.GetFloat("soundVolume"));
            RestartMenuUI.SetActive(true);
            //Time.timeScale = 0f;
            Instantiate(explosion, transform.position, Quaternion.identity);
            forwardSpeed = 0f;
up_Force = 0f;
turnSpeed = 0f;
rotateSpeed = 0f;
            Debug.Log("You Lost");
        }

    if(collision.gameObject.tag == "Finish")
    {
        game_sound.Pause();
        Time.timeScale = 0f;
        WinMenuUI.SetActive(true);
    }
    
    }
}
