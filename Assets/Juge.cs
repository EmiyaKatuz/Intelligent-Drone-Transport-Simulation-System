using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider[] Set=Physics.OverlapSphere(new Vector3(0,100,0),3.0f);
        Debug.Log(Set.Length);
        //Debug.Log("Here");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("1Here");
    }
}
