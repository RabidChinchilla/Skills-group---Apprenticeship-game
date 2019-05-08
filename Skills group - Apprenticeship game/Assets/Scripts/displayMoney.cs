using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayMoney : MonoBehaviour
{
    public Text text;
    private int moneyEarnt;
    void Awake()
    {
        text = GetComponent<Text>();
        moneyEarnt = PlayerPrefs.GetInt("Money");
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "£" + moneyEarnt;
    }
}
