using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayButtonsOnClick : MonoBehaviour {

    public GameObject brickLayingBtn;
    public GameObject pipeLayingBtn;
    private bool active = false;

	public void displayButtons()
    {
        if (active == false)
        {
            brickLayingBtn.SetActive(true);
            pipeLayingBtn.SetActive(true);
            active = true;
        }
        else
        {
            brickLayingBtn.SetActive(false);
            pipeLayingBtn.SetActive(false);
            active = false;
        }
    }
}
