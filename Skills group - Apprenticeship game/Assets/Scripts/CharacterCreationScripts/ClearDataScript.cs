using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ClearDataScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClearData()
    {
        File.Delete(Application.persistentDataPath + "/gamesave.character");
    }
}
