using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzlePieceCheck : MonoBehaviour
{
    public string brickTag;
    public GameObject correctPiece;
    private Vector3 piecePosition;
    private bool mouseDown = false;

    void Start()
    {
        //local transform to get position since it's a child object
        piecePosition = this.transform.position;
    }

    void Update()
    {
        if (this.transform.position != piecePosition)
        {
            this.transform.position = piecePosition;
        }

        if (Input.GetMouseButton(0))
        {
            mouseDown = true;
            //Debug.Log("mouse down");
        }
        else
        {
            mouseDown = false;
            //Debug.Log("mouse up");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (mouseDown == false)
        {
            //Debug.Log("Collided");
            if (collision.gameObject.tag == brickTag)
            {
                Debug.Log("collided");
                //collision.transform.position = this.transform.position;
                correctPiece.SetActive(true);
                Destroy(collision.gameObject);
            }
        }
    }
}
