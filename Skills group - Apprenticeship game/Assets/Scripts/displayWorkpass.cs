using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayWorkpass : MonoBehaviour
{
    public Text text;
    private int workPasses;
    void Awake()
    {
        text = GetComponent<Text>();
        workPasses = PlayerPrefs.GetInt("Work pass");
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + workPasses;
    }
}
