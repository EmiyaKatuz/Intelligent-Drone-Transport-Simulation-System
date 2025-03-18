using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed=20f;
    static int num=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Global.move_list!=null&&Global.move_list.Count==num)
        {
            Global.move_list=null;
            num=0;
        }

        if(Global.move_list!=null)
        {
            if(Global.move_list!=null&&num<Global.move_list.Count)
        {

        
            Vector3 taget=new Vector3(Global.move_list[num].x*10-95,Global.move_list[num].y*10,Global.move_list[num].z*10-95);
            if(transform.position!=taget)
            {
                transform.localPosition= Vector3.MoveTowards(transform.localPosition ,taget, speed * Time.deltaTime);
            }
            else
            {
                num++;
            }
        }
        }
        
    }
}
