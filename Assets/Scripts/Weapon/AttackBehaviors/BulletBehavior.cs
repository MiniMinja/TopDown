using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : GeneralAttackBehavior
{

    public float bulletMovespeed;

    Rigidbody2D rb;


    protected PlayerDataRegistry pd;

    protected override void Start()
    {
        base.Start();
        rb = GetComponent<Rigidbody2D>();

        pd = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDataRegistry>();
        direction = pd.GetDirection();
    }

    protected override void Update()
    {
        base.Update();
    }

    void FixedUpdate()
    {
        rb.rotation = direction;
        rb.velocity = new Vector2(Mathf.Cos(direction / 180 * Mathf.PI), Mathf.Sin(direction / 180 * Mathf.PI)) * bulletMovespeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy"){
            CharacterHealthHandler healthScript = collision.gameObject.GetComponent<CharacterHealthHandler>();
            healthScript.TakeDamage(pd.GetCharacterData().attackPower);
        }
    }
}
