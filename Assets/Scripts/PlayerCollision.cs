using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        

        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit something!");
            GetComponent<PlayerMovement>().enabled = false; //Disables the player movement
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
