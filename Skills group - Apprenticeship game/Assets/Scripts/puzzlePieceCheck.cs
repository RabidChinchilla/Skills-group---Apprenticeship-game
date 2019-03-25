using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzlePieceCheck : MonoBehaviour
{
    public string tag;
    public GameObject correctPiece = null;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "brick1")
        {
            //collision.gameObject.SetActive(false);
            //Instantiate(correctPiece);
            collision.gameObject.transform.position = this.transform.position;
        }
    }
}
