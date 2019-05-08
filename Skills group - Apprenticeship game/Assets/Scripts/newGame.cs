using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newGame : MonoBehaviour
{
    public void setPlayerPrefs()
    {
        PlayerPrefs.SetInt("Money", 0);
        PlayerPrefs.SetInt("Skill", 0);
        PlayerPrefs.SetInt("Work pass", 0);
    }
}
