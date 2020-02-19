using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.Alpha0;
    public KeyCode moveDown = KeyCode.Alpha9;
    public KeyCode moveRight = KeyCode.Alpha8;
    public KeyCode moveLeft = KeyCode.Alpha7;
    public float speed = 2f;
    public float boundY = .37f;
    public float boundZ = .37f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var vel = rb.velocity;
        //rb.velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(moveUp))
        {
            vel.y = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            vel.y = -speed;
        }
        else
        {
            vel.y = 0;
        }
        //rb.velocity = vel;

        if (Input.GetKey(moveRight))
        {
            vel.z = -speed;
        }
        else if (Input.GetKey(moveLeft))
        {
            vel.z = speed;
        }
        else
        {
            vel.z = 0;
        }

        rb.velocity = vel;

        var pos = transform.localPosition;
        if (pos.y >= boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y <= -boundY)
        {
            pos.y = -boundY;
        }

        if (pos.z >= boundZ)
        {
            pos.z = boundZ;
        }
        else if (pos.z <= -boundZ)
        {
            pos.z = -boundZ;
        }
        transform.localPosition = pos;
    }
}
