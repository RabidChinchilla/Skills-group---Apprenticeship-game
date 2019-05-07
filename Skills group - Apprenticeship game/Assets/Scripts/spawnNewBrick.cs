using UnityEngine;

public class spawnNewBrick : MonoBehaviour
{
    public string brickTag;
    private bool brickNeeded = false;
    public GameObject pieceNeeded;
    private Vector3 position;
    private Vector3 piecePosition;
    private Quaternion rotation;


    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        rotation = this.transform.rotation;
        piecePosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (brickNeeded == true)
        {
            Instantiate(pieceNeeded, position, rotation);
            brickNeeded = false;
        }

        if (this.transform.position != piecePosition)
        {
            this.transform.position = piecePosition;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == brickTag)
        {
            brickNeeded = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == brickTag)
        {
            brickNeeded = true;
        }
    }
}
