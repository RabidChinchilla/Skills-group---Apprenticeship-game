using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill : MonoBehaviour
{
    private int oldSkill;

    void Awake()
    {
        oldSkill = PlayerPrefs.GetInt("Skill");
    }

    public void increaseSkill()
    {
        PlayerPrefs.SetInt("Skill", oldSkill + 1);
    }
}
