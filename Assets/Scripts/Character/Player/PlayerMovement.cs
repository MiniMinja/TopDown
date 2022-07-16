using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement
{
    float movepower;

    PlayerMovement(){}

    public void SetMovePower(float movepower)
    {
        this.movepower = movepower;
    }

    public override void Move(Rigidbody2D rb)
    {
        Vector2 dir = (end - start).normalized;
        rb.velocity = dir * movepower;
    }

    static PlayerMovement instance;

    public static PlayerMovement GetInstance(){
        if(instance == null)
        {
            instance = new PlayerMovement();
        }
        return instance;
    }
}
