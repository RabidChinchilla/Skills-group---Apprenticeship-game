using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class educationMiniGame : MonoBehaviour
{
    public GameObject patternPart1;
    public GameObject patternPart2;
    public GameObject patternPart3;
    public GameObject patternPart4;

    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;

    private float buttonSelection;
    private int answer1;
    private int answer2;
    private int answer3;
    private int answer4;

    public int userInput;
    [SerializeField]
    private int answerInput1;
    [SerializeField]
    private int answerInput2;
    [SerializeField]
    private int answerInput3;
    [SerializeField]
    private int answerInput4;
    [SerializeField]
    private int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;

        buttonSelection = Random.Range(0.0f, 1.0f);

        if (buttonSelection <= 0.25f)
        {
            Instantiate(up, patternPart1.transform);
            answer1 = 1;
        }
        else if (buttonSelection <= 0.5f && buttonSelection > 0.25f)
        {
            Instantiate(down, patternPart1.transform);
            answer1 = 2;
        }
        else if (buttonSelection <= 0.75f && buttonSelection > 0.5f)
        {
            Instantiate(left, patternPart1.transform);
            answer1 = 3;
        }
        else if (buttonSelection > 0.75f)
        {
            Instantiate(right, patternPart1.transform);
            answer1 = 4;
        }

        buttonSelection = Random.Range(0.0f, 1.0f);

        if (buttonSelection <= 0.25f)
        {
            Instantiate(up, patternPart2.transform);
            answer2 = 1;
        }
        else if (buttonSelection <= 0.5f && buttonSelection > 0.25f)
        {
            Instantiate(down, patternPart2.transform);
            answer2 = 2;
        }
        else if (buttonSelection <= 0.75f && buttonSelection > 0.5f)
        {
            Instantiate(left, patternPart2.transform);
            answer2 = 3;
        }
        else if (buttonSelection > 0.75f)
        {
            Instantiate(right, patternPart2.transform);
            answer2 = 4;
        }

        buttonSelection = Random.Range(0.0f, 1.0f);

        if (buttonSelection <= 0.25f)
        {
            Instantiate(up, patternPart3.transform);
            answer3 = 1;
        }
        else if (buttonSelection <= 0.5f && buttonSelection > 0.25f)
        {
            Instantiate(down, patternPart3.transform);
            answer3 = 2;
        }
        else if (buttonSelection <= 0.75f && buttonSelection > 0.5f)
        {
            Instantiate(left, patternPart3.transform);
            answer3 = 3;
        }
        else if (buttonSelection > 0.75f)
        {
            Instantiate(right, patternPart3.transform);
            answer3 = 4;
        }

        buttonSelection = Random.Range(0.0f, 1.0f);

        if (buttonSelection <= 0.25f)
        {
            Instantiate(up, patternPart4.transform);
            answer4 = 1;
        }
        else if (buttonSelection <= 0.5f && buttonSelection > 0.25f)
        {
            Instantiate(down, patternPart4.transform);
            answer4 = 2;
        }
        else if (buttonSelection <= 0.75f && buttonSelection > 0.5f)
        {
            Instantiate(left, patternPart4.transform);
            answer4 = 3;
        }
        else if (buttonSelection > 0.75f)
        {
            Instantiate(right, patternPart4.transform);
            answer4 = 4;
        }
    }


    public void getAnswer(int userInput)
    {
        while (i < 4){
            if (i == 0)
            {
                answerInput1 = userInput;
                
                Debug.Log("input " + userInput);
            }
            if(i == 1)
            {
                answerInput2 = userInput;
                
                Debug.Log("input " + userInput);
            }
            if (i == 2)
            {
                answerInput3 = userInput;
                
                Debug.Log("input " + userInput);
            }
            if (i == 3)
            {
                answerInput4 = userInput;
                
                Debug.Log("input " + userInput);
            }
        }
        i += 1;
    }

    void Update()
    {
        
    }
}
