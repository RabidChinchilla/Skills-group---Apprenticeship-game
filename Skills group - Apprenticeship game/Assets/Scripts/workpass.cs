using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class workpass : MonoBehaviour
{
    private int oldAmount;

    void Awake()
    {
        oldAmount = PlayerPrefs.GetInt("Work pass");
    }

    public void addPass()
    {
        PlayerPrefs.SetInt("Work pass", oldAmount + 1);
    }
}
