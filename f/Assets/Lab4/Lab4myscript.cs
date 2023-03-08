using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4myscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,1*Time.deltaTime,0);
        transform.Rotate(Vector3.up*60* Time.deltaTime,Space.World);
        if(transform.position.y>3)
            Application.LoadLevel(Application.loadedLevel);
    }
}
