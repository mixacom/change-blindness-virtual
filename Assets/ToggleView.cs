using UnityEngine;
using System.Collections;

public class ToggleView : MonoBehaviour
{

    GameObject outside;
    GameObject material;

    bool isHidden;

    bool showText = true;
    Rect textArea = new Rect(0, 0, Screen.width, Screen.height); 

    // Use this for initialization
    void Start()
    {
        outside = GameObject.Find("Group46");
        material = GameObject.Find("Mesh47");

        isHidden = false; 
    }

    // Update is called once per frame

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.T))
        {

            if (!isHidden)
            {
                outside.SetActive(false);
                isHidden = true; 
            }
            else
            {
                outside.SetActive(true);
                isHidden = false; 
            }

        }
        
    }

    void OnGUI()
    {
        GUI.Label(new Rect(800, 200, 100, 100), "Follow the ball, dear user.");
    }



}