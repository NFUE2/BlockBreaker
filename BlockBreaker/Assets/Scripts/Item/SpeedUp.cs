using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : Item
{
    [SerializeField] float fixSpeed;

    public override void Active()
    {
        List<GameObject> balls = GameManager.instance.balls;
        for (int i = 0; i < balls.Count; i++)
        {
            Ball ball = balls[i].GetComponent<Ball>();
            ball.speed = fixSpeed;
        }
    }
}
