using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttackBehavior : GeneralAttackBehavior
{

    public float angleOffset;

    protected PlayerDataRegistry pd;

    protected override void Start()
    {
        base.Start();
        pd = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDataRegistry>();
        direction = pd.GetDirection();
    }

    protected override void Update()
    {
        base.Update();
        transform.localRotation = Quaternion.Euler(0, 0, direction + angleOffset);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy"){
            CharacterHealthHandler healthScript = collision.GetComponent<CharacterHealthHandler>();
            healthScript.TakeDamage(pd.GetCharacterData().attackPower);
        }
    }
}
