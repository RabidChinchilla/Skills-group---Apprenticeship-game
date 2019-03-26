using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzlePieceCheck : MonoBehaviour
{
    public string brickTag;
    //public GameObject correctPiece = null;
    private Vector2 piecePosition;

    void Start()
    {
        piecePosition = this.transform.TransformPoint(Vector2.zero);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == brickTag)
        {
            //collision.gameObject.SetActive(false);
            //Instantiate(correctPiece);
            collision.gameObject.transform.position = piecePosition;
        }
    }
}
