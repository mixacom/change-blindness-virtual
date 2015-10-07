using UnityEngine;
using System.Collections;

public class ToggleView : MonoBehaviour
{

    GameObject bin;  
    GameObject boxWhiteBlue;  
    GameObject toy;

    GameObject lamp;
    GameObject wardrobe;
    GameObject TV;
    GameObject chair;
    GameObject pinboard; 

    bool isHidden;

    bool showText = true;
    Rect textArea = new Rect(0, 0, Screen.width, Screen.height);

    bool displayMessage;
    string message;
    string messageForAction;
    string startMessage;

    string finalMessage; 

    // Use this for initialization
    void Start()
    {
        bin = GameObject.Find("Group57");

        lamp = GameObject.Find("Group20");
        wardrobe = GameObject.Find("Group18");
        TV = GameObject.Find("Group68");
        chair = GameObject.Find("Group46");
        pinboard = GameObject.Find("Group47"); 

        isHidden = false;
 
        displayMessage = false;
        message = "You are looking at the bin and it is great.";

        messageForAction = "Have you ever seen such a beatiful bin here? Please, look at it carefully.";
        startMessage = "It's going to start. Get ready to notice a yellow bin, have fun and enjoy it."; 

        finalMessage = "You did it! Thank you. By the way. Have you noticed that something has changed in the room since the beginning? Yeah, really :) "; 

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

        if (TimerForObject.timer > 20 && (!lamp.GetComponent<Renderer>().isVisible)) lamp.SetActive(false);
        if (TimerForObject.timer > 20 && (!wardrobe.GetComponent<Renderer>().isVisible)) wardrobe.SetActive(false);
        if (TimerForObject.timer > 30 && (!TV.GetComponent<Renderer>().isVisible)) TV.SetActive(false);
        if (TimerForObject.timer > 30 && (!chair.GetComponent<Renderer>().isVisible)) chair.SetActive(false);
        if (TimerForObject.timer > 50 && (!pinboard.GetComponent<Renderer>().isVisible)) pinboard.SetActive(false);

    }
 
    void OnGUI()
    {
        if (displayMessage)
        {

        }
        else
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200f, 200f), messageForAction); 
        }

        if (TimerForObject.timer > 1 && TimerForObject.timer < 15)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2 - 300, 200f, 200f), startMessage); 
        }

        if (TimerForObject.timer > 68 || (!ChangeColor.isColorChanging))  
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2 - 300, 200f, 200f), finalMessage); 
        }

    }



}