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
        rend = GetComponent<Renderer>();
    }
    void Update()
    {
        if (TimerForObject.timer > 65)
        {
            rend.material.color = colorYellow;
            isColorChanging = false; 
        }
        else
        {
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
        }
    }
}
