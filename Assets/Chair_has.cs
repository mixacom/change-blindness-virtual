using UnityEngine;
using System.Collections;

public class Chair_has : MonoBehaviour {

    public GameObject menu; // Assign in inspector
    private bool isShowing;
    public Renderer rend; 


    // Use this for initialization
    void Start () {
        rend = this.GetComponent<Renderer>(); 
    }

    // Update is called once per frame 

    void update()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            rend.enabled = !rend.enabled; 
        }

    }

    void Show()
    {
        GetComponent<Renderer>().enabled = true; 
    } 

    void Hide()
    {
        GetComponent<Renderer>().enabled = true; 
    } 

    void HideChildren()
    {
        Renderer[] lChildRenderers = gameObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer lRenderer in lChildRenderers)
        {
            lRenderer.enabled = false;
        }
    } 

    void ShowChildren()
    {
        Renderer[] lChildRenderers = gameObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer lRenderer in lChildRenderers)
        {
            lRenderer.enabled = true;
        }
    }
  
}
