using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))  
        {  
            transform.Translate(0,0,0.5f,Space.Self);
        } 
        if(Input.GetKey(KeyCode.S))  
        {  
            transform.Translate(0,0,-0.5f,Space.Self);
        }        
        if(Input.GetKey (KeyCode.A))  
        {  
            transform.Translate(-0.5f,0,0,Space.Self);
        }        
        if(Input.GetKey(KeyCode.D))  
        {  
            transform.Translate(0.5f,0,0,Space.Self); 
        }
        if(Input.GetMouseButton(1))
        {
        float X=Input.GetAxis("Mouse X")*5;
        float Y=Input.GetAxis("Mouse Y")*5;
        transform.Rotate(-Y,X,0);
        transform.Rotate(0,0,-transform.eulerAngles.z);
        }

    }
}
