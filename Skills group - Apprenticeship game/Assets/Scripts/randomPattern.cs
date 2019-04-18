using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomPattern : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    // Start is called before the first frame update
    void Start()
    {
        Random randomNum = new Random();
        int number = randomNum.Next(0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
