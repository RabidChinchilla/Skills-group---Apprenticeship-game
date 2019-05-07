using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binPieces : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "brick1" || collision.gameObject.tag == "brick2" || collision.gameObject.tag == "brick3" || collision.gameObject.tag == "brick4" || collision.gameObject.tag == "brick5" )
        {
            Destroy(collision.gameObject);
        }
    }
}
