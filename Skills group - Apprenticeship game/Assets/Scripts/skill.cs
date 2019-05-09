using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill : MonoBehaviour
{
    [SerializeField]
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
