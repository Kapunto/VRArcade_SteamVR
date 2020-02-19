using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBallController : MonoBehaviour
{

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("GoBall", 2);
    }

    

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        rand = 1;
        if (rand < 1)
        {
            rb.AddForce(new Vector3(30, -3, -3));
        }
        else
        {
            rb.AddForce(new Vector3(-80, -20, -20));
            Debug.Log("Player gets first shot");
        }
    }

    void ResetBall()
    {
        rb.velocity = Vector3.zero;
        transform.localPosition = Vector3.zero;
    }

    public void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

    void OnCollisionEnter(Collision coll)
    {
        
        Debug.Log("Collision enter: Ball");
        if (coll.collider.CompareTag("Player"))
        {
            GetComponent<Renderer>().material = coll.transform.GetComponent<Renderer>().material;
            Debug.Log("Player hit Ball");
            Vector3 vel = new Vector3();
            vel.x = rb.velocity.x;
            vel.y = (rb.velocity.y) + (coll.collider.attachedRigidbody.velocity.y / 3);
            vel.z = (rb.velocity.z) + (coll.collider.attachedRigidbody.velocity.z / 3);
            rb.velocity = vel;
        }
    }
}
