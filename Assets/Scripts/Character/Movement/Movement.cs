using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{

    protected Vector2 start;
    protected Vector2 end;

    void Move(Rigidbody2D rb)
    {
        //empty
    }

    void Update(Vector2 start, Vector2 end)
    {
        this.start = start;
        this.end = end;
    }
}
