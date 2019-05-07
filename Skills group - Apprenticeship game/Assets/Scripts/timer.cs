using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float timeLeft = 30.0f; //set 30 seconds
    //public bool stop = false;

    private float minutes;
    private float seconds;

    public Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "time Left: " + Mathf.Round(timeLeft); //round so timer looks neat
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("fail");
        }
    }
}
