public class Node
{
    public int x;
    public int y;
    public int z;
    public float f;
    public float g;
    public float h;
    public Node father;
    public int Wakeable;
    public Node(int x,int y,int z,int type)
    {
        this.x=x;
        this.y=y;
        this.z=z;
        this.Wakeable=type;
    }
}