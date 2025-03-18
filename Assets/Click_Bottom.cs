using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Click_Bottom : MonoBehaviour
{
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
        GameObject drone=GameObject.Find("Drone");
        Debug.Log(drone.transform.position);
        Vector3 beg=drone.transform.position;
        Debug.Log(beg.x+1);
        Vector3 b=new Vector3((beg.x+95)/10,beg.y/10,(beg.z+95)/10);
        Debug.Log(b);
        GameObject textObj=GameObject.Find("InputField");
        //Debug.Log(textObj.GetComponent<InputField>().text);
        string context=textObj.GetComponent<InputField>().text;
        string[] str=context.Split(' ');
        Vector3 end=new Vector3(int.Parse(str[0]),int.Parse(str[1]),int.Parse(str[2]));
        //Debug.Log(GameObject.Find("Drone"))
        
        Vector3 begin=new Vector3(29,9,0);
        List<Node> list=Astar.GetInstance().FindPath(b,end);
                Global.move_list=list;
                Debug.Log(Global.move_list);
                if(list!=null)
                {
                    for(int i=0;i<list.Count;i++)
                    {
                        string name=list[i].x+"_"+list[i].y;
                        name+="_";
                        name+=list[i].z;
                        Debug.Log(name);
                        //GameObject obj=GameObject.Find(name);
                        //obj.GetComponent<MeshRenderer>().material=Green;
                    //cubes[name].GetComponent<MeshRenderer>().material=Green;
                    //Debug.Log(cubes[name].GetComponent<Transform>().position);
                        
                        //float speed=1;
                       // transform.localPosition= Vector3.MoveTowards(transform.localPosition ,new Vector3(10,10,10), speed * Time.deltaTime);
                      
                    }
                }
    }
}
