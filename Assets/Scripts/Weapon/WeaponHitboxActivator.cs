using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHitboxActivator : MonoBehaviour
{

    public WeaponHitboxes hitboxes;

    public void Activate(float angle)
    {
        GameObject hitbox = Instantiate(hitboxes.hitbox1, transform);
        hitbox.GetComponent<SwordAttackBehavior>().SetDirection(angle);
        hitbox.transform.localScale /= 0.3f;
        hitbox.SetActive(true);
    }
}
