using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuDisplay : MonoBehaviour
{
    public GameObject buttonOne;
    public GameObject buttonTwo;
    public GameObject schoolBtn = null;
    public GameObject workBtn = null;
    private bool active = false;

    public void displayButtons()
    {
        if (active == false)
        {
            buttonOne.SetActive(true);
            buttonTwo.SetActive(true);
            schoolBtn.SetActive(false);
            workBtn.SetActive(false);
            active = true;
        }
        else
        {
            buttonOne.SetActive(false);
            buttonTwo.SetActive(false);
            schoolBtn.SetActive(true);
            workBtn.SetActive(true);
            active = false;
        }
    }
}
