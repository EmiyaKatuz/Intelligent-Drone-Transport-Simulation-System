using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astar
{
    private static Astar instance;
    private Astar(){}
    public static Astar GetInstance()
    {
        
            if (instance==null)
            instance=new Astar();
            return instance;
        
    }
    public int mapH;
    public int mapW;
    public int mapZ;
    public Node[,,] nodes;
    public List<Node> openlist=new List<Node>();
    public List<Node> closelist=new List<Node>();
    public void InitialMap(int w,int h,int z)
    {
        this.mapH=h;
        this.mapW=w;
        this.mapZ=z;
        nodes=new Node[w,h,z];
        for(int i=0;i<w;i++)
        {
            for(int j=0;j<h;j++)
            {
                for(int k=0;k<z;k++)
                {
                Node node=new Node(i,j,k,1);
                nodes[i,j,k]=node;
                }
            }
        }
    }
    public List<Node> FindPath(Vector3 start,Vector3 end)
    {
        if(
            start.x<0||start.y<0||start.z<0||
            start.x>=mapW||start.y>=mapH||start.y>=mapZ||
            end.x<0||end.y<0||end.z<0||
            end.x>=mapW||end.y>=mapH||end.z>=mapZ
        )
        {
                //Debug.Log("Here");
                return null;
        }

        Node starts =nodes[(int)start.x,(int)start.y,(int)start.z];
        Node ends =nodes[(int)end.x,(int)end.y,(int)end.z];
        if(starts.Wakeable==0||ends.Wakeable==0)
        {
            return null;
        }

        closelist.Clear();
        openlist.Clear();
        starts.father=null;
        starts.f=0;
        starts.g=0;
        starts.h=0;
        closelist.Add(starts);

        while(true){
        FindNearlyNode(starts.x-1,starts.y-1,starts.z,1.4f,starts,ends);
        FindNearlyNode(starts.x+1,starts.y-1,starts.z,1.4f,starts,ends);
        FindNearlyNode(starts.x-1,starts.y+1,starts.z,1.4f,starts,ends);
        FindNearlyNode(starts.x+1,starts.y+1,starts.z,1.4f,starts,ends);
        //
        FindNearlyNode(starts.x-1,starts.y,starts.z-1,1.4f,starts,ends);
        FindNearlyNode(starts.x-1,starts.y,starts.z+1,1.4f,starts,ends);
        FindNearlyNode(starts.x+1,starts.y,starts.z-1,1.4f,starts,ends);
        FindNearlyNode(starts.x+1,starts.y,starts.z+1,1.4f,starts,ends);
        //
        FindNearlyNode(starts.x,starts.y+1,starts.z+1,1.4f,starts,ends);
        FindNearlyNode(starts.x,starts.y+1,starts.z-1,1.4f,starts,ends);
        FindNearlyNode(starts.x,starts.y-1,starts.z+1,1.4f,starts,ends);
        FindNearlyNode(starts.x,starts.y-1,starts.z-1,1.4f,starts,ends);
        //
        FindNearlyNode(starts.x+1,starts.y+1,starts.z+1,1.7f,starts,ends);
        FindNearlyNode(starts.x+1,starts.y+1,starts.z-1,1.7f,starts,ends);
        FindNearlyNode(starts.x+1,starts.y-1,starts.z+1,1.7f,starts,ends);
        FindNearlyNode(starts.x+1,starts.y-1,starts.z-1,1.7f,starts,ends);
        FindNearlyNode(starts.x-1,starts.y+1,starts.z+1,1.7f,starts,ends);
        FindNearlyNode(starts.x-1,starts.y+1,starts.z-1,1.7f,starts,ends);
        FindNearlyNode(starts.x-1,starts.y-1,starts.z+1,1.7f,starts,ends);
        FindNearlyNode(starts.x-1,starts.y-1,starts.z-1,1.7f,starts,ends);
        //
        FindNearlyNode(starts.x-1,starts.y,starts.z,1f,starts,ends);
        FindNearlyNode(starts.x+1,starts.y,starts.z,1f,starts,ends);
        FindNearlyNode(starts.x,starts.y-1,starts.z,1f,starts,ends);
        FindNearlyNode(starts.x,starts.y+1,starts.z,1f,starts,ends);
        FindNearlyNode(starts.x,starts.y,starts.z-1,1f,starts,ends);
        FindNearlyNode(starts.x,starts.y,starts.z+1,1f,starts,ends);

        if(openlist.Count==0)
        {
            return null;
        }
        openlist.Sort(cmp);
        closelist.Add(openlist[0]);
        starts =openlist[0];
        openlist.RemoveAt(0);

        if(starts==ends)
        {
            List<Node> path=new List<Node>();
            path.Add(ends);
            while(ends.father!=null)
            {
                path.Add(ends.father);
                ends=ends.father;
            }
            path.Reverse();
            return path;
        }
        }  
    }
    private int cmp(Node a,Node b)
    {
        if(a.f>b.f)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    
     private void FindNearlyNode(int x,int y,int z,float g,Node father,Node end)
    {
        if(x<0||y<0||z<0||x>=mapW||y>=mapH||z>=mapZ){return ;}
        Node node=nodes[x,y,z];
        if(
            node==null||
            node.Wakeable==0||
            closelist.Contains(node)||
            openlist.Contains(node))
            {
                return;
            }
        node.father=father;
        node.g=father.g+g;
        node.h=Mathf.Abs(end.x-node.x)+Mathf.Abs(end.y-node.y);
        node.f=node.g+node.h;

        openlist.Add(node);

    }




}
