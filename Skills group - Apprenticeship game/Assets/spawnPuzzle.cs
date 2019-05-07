using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPuzzle : MonoBehaviour
{
    public GameObject puzzle1;
    public GameObject puzzle2;
    private float puzzleSelection;


    // Start is called before the first frame update
    void Start()
    {
        puzzleSelection = Random.Range(0.0f, 1.0f);

        if (puzzleSelection < 0.5f)
        {
            Instantiate(puzzle1);
        }
        else
        {
            Instantiate(puzzle2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
