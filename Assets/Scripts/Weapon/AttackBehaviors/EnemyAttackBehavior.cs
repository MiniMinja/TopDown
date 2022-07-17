using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackBehavior : GeneralAttackBehavior
{

    protected EnemyMovementHandler movementScript;

    float angle;

    protected override void Start()
    {
        base.Start();

        movementScript = GetComponentInParent<EnemyMovementHandler>();
    }

    protected override void Update()
    {
        base.Update();
        transform.localRotation = Quaternion.Euler(0, 0, angle);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player"){
            CharacterHealthHandler healthScript = collision.gameObject.GetComponent<CharacterHealthHandler>();
            healthScript.TakeDamage(data.attackPower);
        }
    }

    public void SetAttackDirection(float dir)
    {
        angle = dir;
    }
}
