using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPuzzle : MonoBehaviour
{
    public GameObject puzzle1;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(puzzle1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
