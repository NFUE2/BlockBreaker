using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : Item
{
    [SerializeField] float fixSpeed;

    public override void Active()
    {
        //FindBall();
        //for(int i = 0; i < balls.Length; i++) //프리펩에 등록된 원본이 스피드가 빨라짐
        //{
        //    balls[i].speed = fixSpeed;
        //    Debug.Log(balls[i]);
        //}
    }
}
