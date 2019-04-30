using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzlePiece : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //having error where objects wouldn't appear so attaching this script should make sure they exist in the game scene 
        this.gameObject.SetActive(false);
    }

}
