using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stayInPlace : MonoBehaviour
{
    // Start is called before the first frame update


    private Vector3 location;

    void Start()
    {
        location = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = location;
    }
}
