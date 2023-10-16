using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tech : MonoBehaviour
{


    
    public GameObject player;
    Vector2 playerPos;
    

  
    void Start()
    {
  
    }

  
    void Update()
    {
        /*
        if (Input.GetKey("e") == true)
        {

        }
        */
        playerPos = new Vector2(player.transform.position.x, player.transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, playerPos, 4 * Time.deltaTime);


    }
}
