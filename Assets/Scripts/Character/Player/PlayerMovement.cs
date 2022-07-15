using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : 

{
    float movepower;

    void SetMovePower(float movepower)
    {
        this.movepower = movepower;
    }

    void Move(Rigidbody2D rb)
    {
        Vector2 dir = (end - start).normalized;
        rb = dir * movepower;
    }
}
