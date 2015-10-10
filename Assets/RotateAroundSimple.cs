using UnityEngine;
using System.Collections;

public class RotateAroundSimple : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    private int subFrame;
    private int magnitude;

    private int framenum;
    private int xV;
    private int yV;

    private GameObject fObject; 

    public void start()
    {
        fObject = GameObject.Find("MeshG1"); 
        framenum = 0;

        xV = 2;
        yV = 8;

        rb = fObject.GetComponent<Rigidbody>(); 
        subFrame = 0;
        magnitude = -1000; 
    }

    public void Update()
    {
        Transform target = transform.parent;

        if (target != null && TimerForObject.timeStarted && TimerForObject.timer < 141) 
        {
            transform.RotateAround(target.position, Vector3.up, speed * 0.6f * Time.deltaTime);

            if (subFrame < 5)
            {
                Vector3 movement = new Vector3(0, 1000, 0);
                rb.AddForce(movement);
                subFrame++;
            }
            else
            {
                if (subFrame < 15)
                {
                    rb.AddForce(Vector3.up * magnitude);
                }
                else
                {
                    magnitude = -magnitude;
                    subFrame = 4;
                }
                subFrame++;
            }
            if (framenum < 250)
            {
                Vector3 movex = new Vector3(2, 0, 0);
                rb.AddForce(movex);

                framenum++;
            }
            if (framenum > 249 && framenum < 500)
            {
                Vector3 movex = new Vector3(-2, 0, 0);
                rb.AddForce(movex);

                framenum++;
            }
            if (framenum > 499 && framenum < 750)
            {
                Vector3 movex = new Vector3(-2, 0, 0);
                rb.AddForce(movex);

                framenum++;
            }
            if (framenum > 749)
            {
                Vector3 movex = new Vector3(2, 0, 0);
                rb.AddForce(movex);

                framenum++;
            }



            if (framenum == 1000)
            {
                framenum = 0;
            }


            /*		if (framenum<500) {
                        rb.velocity = new Vector3 (-xVelocity, yVelocity, 0);	
                        framenum++;
                    } 
                    if (framenum>500 ){
                        rb.velocity = new Vector3 (xVelocity,-yVelocity,0);
                        framenum++;
                    }
                    if (framenum == 1000) {
                        framenum =0;
                    }
            */

            rb.useGravity = false;
        }

    }
}