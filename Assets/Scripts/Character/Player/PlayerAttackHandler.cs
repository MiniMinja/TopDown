using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackHandler : MonoBehaviour
{
<<<<<<< HEAD
    public CharacterData charData;

    WeaponHitboxActivator activator;
    string[] weaponChoices;
    int currWeaponIndex;
    bool pauseRotate;
=======
    public Camera cam;

    public CharacterData charData;

    WeaponHitboxActivator activator;
>>>>>>> cfff4a0bd7d9e654b18b9749ce31b0c6ece18420

    bool timeout;
    float timeduration;

    void Start()
    {
        activator = GetComponentInChildren<WeaponHitboxActivator>();
<<<<<<< HEAD
        currWeaponIndex = 0;
        weaponChoices = new string[]{"sword", "gun"};
=======
>>>>>>> cfff4a0bd7d9e654b18b9749ce31b0c6ece18420

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
<<<<<<< HEAD
                activator.Activate();
=======
                Vector2 dir = cam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                activator.Activate(Mathf.Atan2(dir.y, dir.x) / Mathf.PI * 180f);
>>>>>>> cfff4a0bd7d9e654b18b9749ce31b0c6ece18420
                timeout = true;
                timeduration = 0;
            }
        }
<<<<<<< HEAD

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
=======
>>>>>>> cfff4a0bd7d9e654b18b9749ce31b0c6ece18420
    }
}
