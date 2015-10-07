using UnityEngine;
using System.Collections;

public class RotateAroundSimple : MonoBehaviour
{
    public float speed;

    public void Update()
    {
        Transform target = transform.parent;

        if (target != null && TimerForObject.timer > 10 && TimerForObject.timer < 68) 
        {
            transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
        }
    }
}