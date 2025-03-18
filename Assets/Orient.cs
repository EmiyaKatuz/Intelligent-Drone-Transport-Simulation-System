using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orient : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
        float X=Input.GetAxis("Mouse X")*5;
        float Y=Input.GetAxis("Mouse Y")*5;
        transform.Rotate(-Y,X,0);
        transform.Rotate(0,0,-transform.eulerAngles.z);
        } 
    }
}
