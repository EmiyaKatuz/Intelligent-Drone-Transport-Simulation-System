using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View_Change : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))  
        {  
            camera1.SetActive(false);
            Debug.Log("Press");
            camera2.SetActive(true);
        } 
        if(Input.GetKeyDown(KeyCode.K))  
        {  
            camera2.SetActive(false);
            Debug.Log("Press");
            camera1.SetActive(true);
        }
        
    }
}
