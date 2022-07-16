using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement
{
    protected float movespeed;

    public abstract void Move(Rigidbody2D rb);
    public virtual void SetMovespeed(float ms)
    {
        this.movespeed = ms;
    }
}
