using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    private SpriteRenderer eyeSpriteRenderer;
    private SpriteRenderer noseSpriteRenderer;
    private SpriteRenderer mouthSpriteRenderer;
    private SpriteRenderer hairSpriteRenderer;
    private SpriteRenderer eyebrowSpriteRenderer;
    private SpriteRenderer pupilSpriteRenderer;
    private SpriteRenderer skinColourRenderer;


    public GameObject headBase;
    public GameObject eyes;
    public GameObject pupils;
    public GameObject nose;
    public GameObject mouth;
    public GameObject hair;
    public GameObject eyebrows;

    // Start is called before the first frame update
    void Start()
    {
        //initialise renderers
        eyeSpriteRenderer = eyes.GetComponent<SpriteRenderer>();
        noseSpriteRenderer = nose.GetComponent<SpriteRenderer>();
        mouthSpriteRenderer = mouth.GetComponent<SpriteRenderer>();
        hairSpriteRenderer = hair.GetComponent<SpriteRenderer>();
        eyebrowSpriteRenderer = eyebrows.GetComponent<SpriteRenderer>();
        pupilSpriteRenderer = pupils.GetComponent<SpriteRenderer>();
        skinColourRenderer = headBase.GetComponent<SpriteRenderer>();


        //Load Character
        LoadCharacter();
    }


    /// <summary>
    /// Stores Character Data inPlayerPrefsCharacterSaver class
    /// </summary>
    /// <returns></returns>
    public PlayerPrefsCharacterSaver StoreCharacterData()
    {
        PlayerPrefsCharacterSaver save = new PlayerPrefsCharacterSaver();

        save.eyebrowSprite = eyebrowSpriteRenderer.sprite.name;
        save.eyeSprite = eyeSpriteRenderer.sprite.name;
        save.mouthSprite = mouthSpriteRenderer.sprite.name;
        save.noseSprite = noseSpriteRenderer.sprite.name;
        save.hairSprite = hairSpriteRenderer.sprite.name;
        save.pupilSprite = pupilSpriteRenderer.sprite.name;

        save.skinColour.Add(skinColourRenderer.color.r);
        save.skinColour.Add(skinColourRenderer.color.g);
        save.skinColour.Add(skinColourRenderer.color.b);

        save.hairColour.Add(hairSpriteRenderer.color.r);
        save.hairColour.Add(hairSpriteRenderer.color.g);
        save.hairColour.Add(hairSpriteRenderer.color.b);

        save.eyeColour.Add(pupilSpriteRenderer.color.r);
        save.eyeColour.Add(pupilSpriteRenderer.color.g);
        save.eyeColour.Add(pupilSpriteRenderer.color.b);

        return save;
    }

    //saves character
    public void SaveCharacter()
    {
        PlayerPrefsCharacterSaver save = StoreCharacterData();

        //serialise data and pass to disk
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.character");
        bf.Serialize(file, save);
        file.Close();
    }
    public void LoadCharacter()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.character"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.character", FileMode.Open);
            PlayerPrefsCharacterSaver save = (PlayerPrefsCharacterSaver)bf.Deserialize(file);
            file.Close();


            eyebrowSpriteRenderer.sprite = Resources.Load<Sprite>(save.eyebrowSprite);
            eyeSpriteRenderer.sprite= Resources.Load<Sprite>(save.eyeSprite);
            mouthSpriteRenderer.sprite = Resources.Load < Sprite > (save.mouthSprite);
            noseSpriteRenderer.sprite = Resources.Load < Sprite > (save.noseSprite);
            hairSpriteRenderer.sprite = Resources.Load < Sprite > (save.hairSprite);
            pupilSpriteRenderer.sprite = Resources.Load<Sprite>(save.pupilSprite);

            skinColourRenderer.color= new Color(save.skinColour[0], save.skinColour[1], save.skinColour[2],1);
            hairSpriteRenderer.color = new Color(save.hairColour[0],save.hairColour[1],save.hairColour[2],1);
            pupilSpriteRenderer.color = new Color(save.eyeColour[0],save.eyeColour[1],save.eyeColour[2],1);

        }
    }
}
