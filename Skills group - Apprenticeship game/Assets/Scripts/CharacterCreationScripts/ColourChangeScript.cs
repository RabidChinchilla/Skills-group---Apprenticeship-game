using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChangeScript : MonoBehaviour
{
    //array of sprites to change (account for hair and eyebrows
    public GameObject[] spriteList;

    // rgba component of colour
    public byte r; 
    public byte g;
    public byte b;
    private byte transparency;


    private Color32 color;
    // Start is called before the first frame update
    void Start()
    {
        // sets transparency to completely opaque
        transparency = 255;
        //gets desired colour using rgba
        color = new Color32(r, g, b, transparency);

        
    }

    //changes sprite colour
   public void ChangeColour()
    {
        foreach (GameObject sprite in spriteList)
        {
            sprite.GetComponent<SpriteRenderer>().color = color;
        }
    }


}
