using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCanvasScript : MonoBehaviour
{
    //Canvas you wish to display
    public GameObject desiredCanvas;

    private GameObject currentCanvas;
    // Start is called before the first frame update
    void Start()
    {
        currentCanvas = GameObject.FindGameObjectWithTag("CurrentCanvas");

    }

    public void ChangeCanvas()
    {

        if (desiredCanvas.tag != "CurrentCanvas")
        {
            currentCanvas = GameObject.FindGameObjectWithTag("CurrentCanvas");
            currentCanvas.SetActive(false);
            desiredCanvas.SetActive(true);
            currentCanvas.tag = "DeactivatedCanvas";
            desiredCanvas.tag = "CurrentCanvas";
        }
    }

}
