using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalMovement : Movement
{
    float angle;
    float throttle;

    public override void Move(Rigidbody2D rb)
    {
        Vector2 dir = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        rb.velocity = dir * movespeed * throttle;
    }

    public void UpdateDirection(float angle)
    {
        this.angle = angle;
    }

    public void SetThrottle(float power)
    {
        throttle = power;
    }

}
