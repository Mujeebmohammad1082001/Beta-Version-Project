using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "player")
        {
            Debug.Log("You Loose");
            other.gameObject.SetActive(false);
        }
    }
}
