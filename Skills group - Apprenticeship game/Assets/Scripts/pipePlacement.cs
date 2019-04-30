using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipePlacement : MonoBehaviour {

    [SerializeField]
    private string correctObjectTag = " ";
    [SerializeField]
    private GameObject correctObject;

    //private bool dragging;

    // Start is called before the first frame update
    void Start()
    {
        //dragging = dragAndDrop.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision!");
        if(collision.gameObject.tag == correctObjectTag)
        {
            Debug.Log("Can place");
            correctObject.SetActive(true);
            collision.gameObject.SetActive(false);

        }
    }
}
