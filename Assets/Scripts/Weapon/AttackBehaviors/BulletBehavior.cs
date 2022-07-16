using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : GeneralAttackBehavior
{

    public float bulletMovespeed;

    Rigidbody2D rb;

    bool directionSet;

    protected override void Start()
    {
        base.Start();
        rb = GetComponent<Rigidbody2D>();
        directionSet = false;
    }

    protected override void Update()
    {
        base.Update();
        if(!directionSet){
            direction = pd.GetDirection();
            directionSet = true;
        }
        rb.rotation = direction;
        rb.velocity = new Vector2(Mathf.Cos(direction / 180 * Mathf.PI), Mathf.Sin(direction / 180 * Mathf.PI)) * bulletMovespeed;
    }
}
