using UnityEngine;
using System.Collections;

public class TimerForObject : MonoBehaviour {

    public static float timer;

    public static bool timeStarted;

    public float seconds;
    
    
    void Start()
    {

        timeStarted = true; 

    }

    void Update()
    {
        if (timeStarted == true)
        {
            timer += Time.deltaTime; 
        }

        seconds = timer % 60;

    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 250, 100), seconds.ToString());
    }
  
}
