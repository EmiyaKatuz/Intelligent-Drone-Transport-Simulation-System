using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
     public float _RotationSpeed=4;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {transform.Rotate(Vector3.up*4); 
        //transform.Rotate(new Vector3(1,0,0),Space.Self);
    }
}
