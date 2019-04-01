using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzlePieceCheck : MonoBehaviour
{
    public string brickTag;
    public GameObject correctPiece;
    private Vector3 piecePosition;

    void Start()
    {
        //local transform to get position since it's a child object
        piecePosition = this.transform.localPosition;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == brickTag)
        {
            //collision.gameObject.SetActive(false);
            //Instantiate(correctPiece);
            Debug.Log("collided");
            correctPiece.SetActive(true);
            collision.gameObject.transform.position = piecePosition;
        }
    }
}
