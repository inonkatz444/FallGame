using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody player;
    public float movementForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            player.AddForce(-movementForce, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            player.AddForce(movementForce, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            player.AddForce(0, movementForce, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            player.AddForce(0, -movementForce, 0, ForceMode.VelocityChange);
        }
    }
}
