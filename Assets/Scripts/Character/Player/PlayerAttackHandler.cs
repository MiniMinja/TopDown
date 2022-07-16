using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackHandler : MonoBehaviour
{
    public CharacterData charData;

    WeaponHitboxActivator activator;
    string[] weaponChoices;
    int currWeaponIndex;
    bool pauseRotate;

    bool timeout;
    float timeduration;

    void Start()
    {
        activator = GetComponentInChildren<WeaponHitboxActivator>();
        currWeaponIndex = 0;
        weaponChoices = new string[]{"sword", "gun"};

        timeout = false;
        timeduration = 0;
    }

    void Update()
    {
        timeduration += Time.deltaTime;
        if(timeduration > 1 / charData.attackSpeed){
            timeout = false;
        }


        if(Input.GetAxisRaw("Fire1") == 1)
        {
            if(!timeout)
            {
                activator.Activate();
                timeout = true;
                timeduration = 0;
            }
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            if(!pauseRotate){
                RotateWeapon();
            }
            pauseRotate = true;
        }

        if(Input.GetKeyUp(KeyCode.P))
        {
            pauseRotate = false;
        }
    }

    public void RotateWeapon()
    {
        currWeaponIndex++;
        if(currWeaponIndex == weaponChoices.Length)
        {
            currWeaponIndex = 0;
        }
        activator.SetWeapon(weaponChoices[currWeaponIndex]);
        Debug.Log("Current Weapon: " + weaponChoices[currWeaponIndex]);
    }
}
