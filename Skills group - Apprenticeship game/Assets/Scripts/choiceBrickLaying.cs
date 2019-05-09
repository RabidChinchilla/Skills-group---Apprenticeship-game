using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choiceBrickLaying : MonoBehaviour
{
    private int career;

    private int oldWorkPass;

    void Awake()
    {
        oldWorkPass = PlayerPrefs.GetInt("Work pass");
    }

    public void setCareer(int choice)
    {
        if (choice == 1)
        {
            PlayerPrefs.SetInt("Career", 0);
        }
        else if (choice == 2)
        {
            PlayerPrefs.SetInt("Career", 1);
        }
    }

    public void getCareer()
    {
        if (oldWorkPass > 0)
        {
            career = PlayerPrefs.GetInt("Career");
            if (career == 0)
            {
                PlayerPrefs.SetInt("Work pass", oldWorkPass - 1);
                SceneManager.LoadScene("Brick laying work");
            }
            else if (career == 1)
            {
                PlayerPrefs.SetInt("pipe win condition", 0);
                PlayerPrefs.SetInt("Work pass", oldWorkPass - 1);
                SceneManager.LoadScene("Pipe laying");
            }
        }
    }
}
