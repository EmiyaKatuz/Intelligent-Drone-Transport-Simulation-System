using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    // Start is called before the first frame update
    public  LineRenderer lineRenderer1;
    public  int index=0;
    public float time=0f;
    void Start()
    {
       //lineRenderer1.SetVertexCount(1000);
       // lineRenderer1.positionCount=10;
        // Vector3 pos=this.transform.localPosition;
        // lineRenderer1.SetPosition(index,pos);
        // index++;
    }

    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
        if(time>1f){
        lineRenderer1.positionCount=index; 
        Vector3 pos=this.transform.localPosition;
        // Debug.Log(pos);
        //  Debug.Log(index);
        //Vector3 pos2=new Vector3(0f,0f,0f);
       // Debug.log(this.LineRenderer.positionCount)
        lineRenderer1.SetPosition(index-1,pos);
        index++;
        time=0f;
       // lineRenderer1.positionCount=index;
        }
    }
}
