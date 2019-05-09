using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{

    public Text text;
    private int moneyEarnt;
    private int previousMoney;
    private int skillLevel;
    void Start()
    {
        text = GetComponent<Text>();
        skillLevel = PlayerPrefs.GetInt("Skill");
        previousMoney = PlayerPrefs.GetInt("Money");
        moneyEarnt = 15 + skillLevel;
        PlayerPrefs.SetInt("Money", previousMoney + moneyEarnt);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "you've earnt: £" + moneyEarnt;
    }
}
