using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pipePlacement : MonoBehaviour {

    [SerializeField]
    private string correctObjectTag = " ";

    

    private Rigidbody2D rb;

    private Collider2D boxCollider;

    private bool canPlace;

    private Vector3 targetLocation;

    private Collider2D targetCollider;

    private SpriteRenderer tint;
    [SerializeField]
    private int winCondition;

    // Start is called before the first frame update
    void Start()
    {
        canPlace = false;
       
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        tint = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        winCondition = PlayerPrefs.GetInt("pipe win condition");

        if (Input.GetMouseButtonUp(0))
        {
            if (canPlace == true)
            {
                //Instantiate(correctObject, targetLocation.transform);

                boxCollider.enabled = false;
                targetCollider.enabled = false;
                gameObject.transform.position = targetLocation;
                Debug.Log("Placed");

                tint.color = Color.green;

                PlayerPrefs.SetInt("pipe win condition", winCondition + 1);


            }
        }

        if (winCondition == 10)
        {
            SceneManager.LoadScene("Win");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision!");
        if(collision.gameObject.tag == correctObjectTag)
        {
            Debug.Log("Can place");
            canPlace = true;
            targetLocation = new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z - 1);
            targetCollider = collision.gameObject.GetComponent<Collider2D>();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == correctObjectTag)
        {
            canPlace = false;
            
        }
    }
}

