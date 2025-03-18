using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Select_Point : MonoBehaviour
{
    public Material Red;
    public Material Green;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        
        Debug.Log("Click");
        GameObject textObj=GameObject.Find("InputField");
        string context=textObj.GetComponent<InputField>().text;
        string[] str=context.Split(' ');
        string objname=str[0]+"_"+str[1]+"_"+str[2];
        Debug.Log(objname);
        // GameObject CubeObj=GameObject.Find(objname);
        // CubeObj.SetActive(true);
        GameObject obj=GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.transform.localScale=new Vector3(5,5,5);
        if(Astar.GetInstance().nodes[System.Int32.Parse(str[0]),System.Int32.Parse(str[1]),System.Int32.Parse(str[2])].Wakeable==1)
        {
            obj.GetComponent<MeshRenderer>().material =Red;
        }
        else
        {
            obj.GetComponent<MeshRenderer>().material =Green;
        }

        obj.transform.position =new Vector3(-95+System.Int32.Parse(str[0])*10,0+System.Int32.Parse(str[1])*10,-95+System.Int32.Parse(str[2])*10);
        
    }
}
