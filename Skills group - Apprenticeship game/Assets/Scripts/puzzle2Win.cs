using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puzzle2Win : MonoBehaviour
{

    public GameObject piece1;
    public GameObject piece2;
    public GameObject piece3;
    public GameObject piece4;
    public GameObject piece5;
    public GameObject piece6;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((piece1.activeSelf == true) && (piece2.activeSelf == true) && (piece3.activeSelf == true) && (piece4.activeSelf == true) && (piece5.activeSelf == true) && (piece6.activeSelf == true))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
