using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreseSize : Item
{
    [SerializeField] Vector3 size;

    public override void Active()
    {
        //FindBall();

        //for(int i = 0; i < balls.Length; i++)
        //{
        //    GameObject ball = balls[i].gameObject;
        //    ball.transform.localScale = size;
        //}
    }
}
