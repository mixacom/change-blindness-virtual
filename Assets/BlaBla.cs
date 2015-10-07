using UnityEngine;
using System.Collections;

public class BlaBla : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
    private int framenum;
    private int magnitude;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        framenum = 0;
        magnitude = -400;
    }
    //FixedUpdate should be used instead of Update when dealing with Rigidbody
    void FixedUpdate()
    {
        //		float moveHorizontal = Input.GetAxis ("Horizontal");
        //		float moveVertical = Input.
        //		Vector3 movement = new Vector3 (Random.Range(-10.0F, 10.0F), 0, Random.Range(-10.0F, 10.0F));
        if (framenum < 5)
        {
            Vector3 movement = new Vector3(-400, 400, 0);
            rb.AddForce(movement);
            framenum++;
        }
        else
        {
            Vector3 velocity = rb.velocity;
            velocity.y = 0;
            rb.AddForce(Vector3.Cross(velocity, Vector3.up));
            if (framenum < 15)
            {
                rb.AddForce(Vector3.up * magnitude);
            }
            else
            {
                magnitude = -magnitude;
                framenum = 4;
            }
            framenum++;
        }

        rb.useGravity = false;
    }

}