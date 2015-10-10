using UnityEngine;
using System.Collections;

public class TimerForObject : MonoBehaviour {

    public static float timer;

    public static bool timeStarted;

    public float seconds; 
    
    
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            timeStarted = true;   
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            timeStarted = false; 
        } 

        if (timeStarted == true)
        {
            timer += Time.deltaTime; 
        }

        seconds = timer % 60;

    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 250, 100), timer.ToString());
    }
  
}
