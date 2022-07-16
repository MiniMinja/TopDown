using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement
{

    protected Vector2 start;
    protected Vector2 end;

    public abstract void Move(Rigidbody2D rb);

    public void Update(Vector2 start, Vector2 end)
    {
        this.start = start;
        this.end = end;
    }
}
