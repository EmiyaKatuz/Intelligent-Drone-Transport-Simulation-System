using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initial : MonoBehaviour
{
    public int InitialX=-95;
    public int InitialY=0;
    public int InitialZ=-95;
    public int OffsetX=10;
    public int OffsetY=10;
    public int OffsetZ=10;
    public int MaxX=300;
    public int MaxY=100;
    public int MaxZ=300;
    public Material Red;
    public Material Green;
    // Start is called before the first frame update
    void Start()
    {
        Astar.GetInstance().InitialMap(MaxX,MaxY,MaxZ);
        for(int i=0;i<MaxX;i++)
        {
            for(int j=0;j<MaxY;j++)
            {
                for(int k=0;k<MaxZ;k++)
                {
                    Collider[] Set=Physics.OverlapSphere(new Vector3(InitialX+i*OffsetX,InitialY+j*OffsetY,InitialZ+k*OffsetZ),3.0f);
                    //Debug.Log(Set.Length);
                    GameObject obj=GameObject.CreatePrimitive(PrimitiveType.Cube);
                    obj.SetActive(false);
                    obj.transform.position =new Vector3(InitialX+i*OffsetX,InitialY+j*OffsetY,InitialZ+k*OffsetZ);
                    obj.name=i+"_"+j+"_"+k;
                    Node node =Astar.GetInstance().nodes[i,j,k];
                    if(Set.Length!=0)
                    {
                        node.Wakeable=0;
                        obj.GetComponent<MeshRenderer>().material =Red;

                    }
                    Astar.GetInstance().nodes[i,j,k]=node;
                    //Debug.Log(Astar.GetInstance().nodes[i,j,k].Wakeable);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // RaycastHit Info;
            // Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            // if(Physics.Raycast(ray,out Info,1000))
            // {
            //    //Debug.Log(Vector2.right);
                
            //     Debug.Log(Info.collider.gameObject.name);
            //     string[] str=Info.collider.gameObject.name.Split('_');
            //     Info.collider.gameObject.GetComponent<MeshRenderer>().material=Red;
            //     Vector3 end=new Vector3(int.Parse(str[0]),int.Parse(str[1]),int.Parse(str[2]));
            //     Vector3 begin=new Vector3(29,9,0);
            //     Debug.Log(Astar.GetInstance().nodes[29,9,0].Wakeable);
            //     Debug.Log(begin);
            //     Debug.Log(end);
            //     List<Node> list=Astar.GetInstance().FindPath(begin,end);
            //     Global.move_list=list;
            //     Debug.Log(Global.move_list);
            //     if(list!=null)
            //     {
            //         for(int i=0;i<list.Count;i++)
            //         {
            //             string name=list[i].x+"_"+list[i].y;
            //             name+="_";
            //             name+=list[i].z;
            //             Debug.Log(name);
            //             GameObject obj=GameObject.Find(name);
            //             obj.GetComponent<MeshRenderer>().material=Green;
            //         //cubes[name].GetComponent<MeshRenderer>().material=Green;
            //         //Debug.Log(cubes[name].GetComponent<Transform>().position);
                        
            //             //float speed=1;
            //            // transform.localPosition= Vector3.MoveTowards(transform.localPosition ,new Vector3(10,10,10), speed * Time.deltaTime);
                      
            //         }
            //     }
            // }
            




        }
    }
}
