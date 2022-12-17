using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_spawn : MonoBehaviour
{
    public GameObject[] thing;
    float positionZ = 0;
    int spawn_num = 0;
    public int max_road = 10;
    public GameObject finishRoad;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnThings" , 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnThings()
    {
        int RandomOp = Random.Range(0, thing.Length);
        if (spawn_num < max_road)
        {
            GameObject gameObject = Instantiate(thing[RandomOp] , new Vector3(0, 0, positionZ) , Quaternion.Euler(new Vector3(-90, -90, -90)));
            positionZ += 59;
            spawn_num += 1;
            Invoke("spawnThings", 0);
        }
        else
        {
            Instantiate(finishRoad , new Vector3(0, 0, positionZ) , Quaternion.Euler(new Vector3(-90, -90, -90)));

        }


    }
}
