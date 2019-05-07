using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prototypePuzzleWin : MonoBehaviour
{

    public GameObject piece1;
    public GameObject piece2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((piece1.activeSelf == true) && (piece2.activeSelf == true))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
