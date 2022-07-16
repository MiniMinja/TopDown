using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHitboxActivator : MonoBehaviour
{

    public WeaponHitboxes swordHitbox;
    public WeaponHitboxes gunHitbox;

    string weaponKey;
    WeaponHitboxes currentHitbox;

    void Start()
    {
        weaponKey = "sword";
        currentHitbox = swordHitbox;
    }

    public void Activate()
    {
        GameObject hitbox = Instantiate(currentHitbox.hitbox1, transform);
        hitbox.SetActive(true);
    }

    public void SetWeapon(string key){
        this.weaponKey = key;
        if(key == "sword")
        {
            currentHitbox = swordHitbox;
        }
        else if(key == "gun")
        {
            currentHitbox = gunHitbox;
        }
    }

}
