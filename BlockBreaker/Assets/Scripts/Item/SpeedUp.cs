using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : Item
{
    [SerializeField] float fixSpeed;

    public override void Active()
    {
        //FindBall();
        //for(int i = 0; i < balls.Length; i++) //�����鿡 ��ϵ� ������ ���ǵ尡 ������
        //{
        //    balls[i].speed = fixSpeed;
        //    Debug.Log(balls[i]);
        //}
    }
}
