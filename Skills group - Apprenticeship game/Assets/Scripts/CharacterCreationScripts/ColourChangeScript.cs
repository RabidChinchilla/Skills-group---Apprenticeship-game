using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChangeScript : MonoBehaviour
{
    // rgba component of colour
    public byte r; 
    public byte g;
    public byte b;
    private byte transparency;

    //sprite to be changed
    public GameObject sprite;

    private Color32 color;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        // sets transparency to completely opaque
        transparency = 255;
        //gets desired colour using rgba
        color = new Color32(r, g, b, transparency);

        spriteRenderer = sprite.GetComponent<SpriteRenderer>();

    }

    //changes sprite colour
   public void ChangeColour()
    {
        spriteRenderer.color = color;
    }


}
