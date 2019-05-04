using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTypeScript : MonoBehaviour
{
    //Part of face to be changed (eg Eyes)
    public GameObject changingPart;

    //Extra Changes list (For Eyes)
    public GameObject[] extraSpritesList;
    public Sprite[] desiredExtraSpriteList;
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
        
        if (extraSpritesList.Length != 0)
        {
            for (int i = 0; i < extraSpritesList.Length; i++)
            {
                extraSpritesList[i].GetComponent<SpriteRenderer>().sprite = desiredExtraSpriteList[i];
            }
        }
    }

    

}
