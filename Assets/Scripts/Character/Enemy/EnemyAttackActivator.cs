using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackActivator : MonoBehaviour
{
    public WeaponHitboxes hitboxes;

    float angle;

    void Start()
    {
        
    }

    public void Activate()
    {
        GameObject hitbox = Instantiate(hitboxes.hitbox1, transform);
        hitbox.GetComponent<EnemyAttackBehavior>().SetAttackDirection(angle);
        hitbox.SetActive(true);
    }

    public void SetDirectionAngle(float angle)
    {
        this.angle = angle / Mathf.PI * 180;
    }
}
