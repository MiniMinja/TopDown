using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationMovement : Movement
{
    Vector2 end;

    public override void Move(Rigidbody2D rb)
    {
            Vector2 dir = (end - rb.position).normalized;
            rb.velocity = dir * movespeed;
    }

    public void UpdateDestination(Vector2 end)
    {
        this.end = end;
    }

}
