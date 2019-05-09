using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displaySkill : MonoBehaviour
{
    public Text text;
    [SerializeField]
    private int Skill;
    void Awake()
    {
        text = GetComponent<Text>();
        Skill = PlayerPrefs.GetInt("Skill");
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + Skill;
    }
}
