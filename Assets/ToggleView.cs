using UnityEngine;
using System.Collections;

public class ToggleView : MonoBehaviour
{

    GameObject bin;  
    GameObject boxWhiteBlue;  
    GameObject toy; 

    bool isHidden;

    bool showText = true;
    Rect textArea = new Rect(0, 0, Screen.width, Screen.height);

    bool displayMessage;
    string message;
    string messageForAction; 

    // Use this for initialization
    void Start()
    {
        bin = GameObject.Find("Group57");
        boxWhiteBlue = GameObject.Find("Group26"); 
        toy = GameObject.Find("Group56"); 

        isHidden = false;
 
        displayMessage = false;
        message = "You are looking at the bin and it is great.";

        messageForAction = "Have you ever seen such a beatiful bin here? Please, look at it carefully."; 
    }

    // Update is called once per frame

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.T)) 
        {
            if (!isHidden)
            {
                toy.SetActive(false);
                isHidden = true; 
            }
            else
            {
                toy.SetActive(true);
                isHidden = false; 
            }
        }

        if (bin.GetComponent<Renderer>().isVisible) { 
            displayMessage = true;
        }
        else { 
            displayMessage = false;
        }

        if (TimerForObject.timer > 10)
        {
            if (!bin.GetComponent<Renderer>().isVisible)
            {

                boxWhiteBlue.SetActive(false);

            }
        }
 
        if (TimerForObject.timer > 15)
        {
            if (!bin.GetComponent<Renderer>().isVisible)
            {

                toy.SetActive(false);

            }
        }
    }
 
    void OnGUI()
    {
        if (displayMessage)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200f, 200f), message);
        }
        else
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200f, 200f), messageForAction); 
        }
    }



}