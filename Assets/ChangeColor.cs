using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour
{
    public Color colorStart = Color.red;
    public Color colorEnd = Color.green;
    public Color colorYellow = Color.yellow; 
    public float duration = 10.0F;
    public static bool isColorChanging = true; 
    public Renderer rend;
    void Start()
    {
        rend =  GameObject.Find("MeshG2").GetComponent<Renderer>();
    }
    void Update()
    {
        if (TimerForObject.timer > 140) 
        {
            rend.material.color = colorYellow;
            isColorChanging = false; 
        }
        else if (TimerForObject.timeStarted)
        {
            
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
            

            System.Console.WriteLine(rend.materials); 
        }
    }
}
