using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : Item
{
    [SerializeField] GameObject ball;
    [SerializeField] int createCount;

    public override void Active()
    {
        for(int i = 0; i < createCount; i++)
        {
            Instantiate(ball,transform.position,Quaternion.identity);
        }
    }
}
