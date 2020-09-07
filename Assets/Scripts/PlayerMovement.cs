using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float ForwardForce = 2000f;
    public float sidewaysForce = 500f;

    public float UnderGround = -1f;

    public float upForce = 500f;

    public Rigidbody rb;

    //Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // Add a forward force.
        rb.AddForce(0, 0, 0);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -ForwardForce * Time.deltaTime);
        }

        if (Input.GetKey("space"))
        {
            rb.AddForce(0, upForce * Time.deltaTime, 0);
        }

        if(rb.position.y < UnderGround)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
