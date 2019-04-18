using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomPattern : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject postion1;
    public GameObject postion2;
    public GameObject postion3;
    public GameObject postion4;

    // Start is called before the first frame update
    void Start()
    {
        System.Random randomNum = new System.Random();
        int number = randomNum.Next(0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
