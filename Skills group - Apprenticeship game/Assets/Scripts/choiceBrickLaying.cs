using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choiceBrickLaying : MonoBehaviour
{
    private int career;

    public void setCareer(int choice)
    {
        if (choice == 1)
        {
            PlayerPrefs.SetInt("Career", 1);
        }
        else if (choice == 2)
        {
            PlayerPrefs.SetInt("Career", 2);
        }
    }

    public void getCareer()
    {
        career = PlayerPrefs.GetInt("Career");
        if (career == 1)
        {
            SceneManager.LoadScene("Brick laying work");
        }
        else if (career == 2)
        {
            PlayerPrefs.SetInt("pipe win condition", 0);
            SceneManager.LoadScene("Pipe laying");
        }
    }
}
