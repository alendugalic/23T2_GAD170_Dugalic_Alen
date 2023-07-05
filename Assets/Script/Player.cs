using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementspeed = 20f;
    private void Update()
    {

       
        //move our object based on input from the player
        // well need and IF STATEMENT when we want to get the player imput

        int playerScore = 1;
        playerScore++;
        playerScore = playerScore + 1;

        // transform.position++; DOESNT WORK
        Vector3 moveDirection = Vector3.forward;
        //transform.position = transform.position + moveDirection;

        // When player presses arrow keys 
        // the game object moves in direction
        // we need to create a vector
        // W, Y, Z
        // 0
        // If pressing D then move +X
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += (Vector3.right * movementspeed) * Time.deltaTime;
        }


        //if pressing A then move -X
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += (Vector3.left * movementspeed) *Time.deltaTime;

        }

        // if pressing  W then move +Z
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += (Vector3.forward * movementspeed) * Time.deltaTime;
        }

        // if pressing S then move -Z
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += (Vector3.back * movementspeed) * Time.deltaTime;
        }
        // if pressing space then +Y
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += (Vector3.up * movementspeed) *Time.deltaTime;
        }
        // if pressing Alt then -Y
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            transform.position += (Vector3.down * movementspeed) *Time.deltaTime;
        }



    }
}

    
    
        
    

