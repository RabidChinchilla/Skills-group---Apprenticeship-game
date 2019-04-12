using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTypeScript : MonoBehaviour
{
    //Part of face to be changed (eg Eyes)
    public GameObject changingPart;

    //Sprite to be set
    public Sprite desiredSprite;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = changingPart.GetComponent<SpriteRenderer>();
    }

    //Changes sprite of Game Object to desired sprite
    public void ChangeSprite()
    {
        spriteRenderer.sprite = desiredSprite;
    }

}
