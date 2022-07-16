using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackHandler : MonoBehaviour
{
    public Camera cam;

    public CharacterData charData;

    WeaponHitboxActivator activator;

    bool timeout;
    float timeduration;

    void Start()
    {
        activator = GetComponentInChildren<WeaponHitboxActivator>();

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
                Vector2 dir = cam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                activator.Activate(Mathf.Atan2(dir.y, dir.x) / Mathf.PI * 180f);
                timeout = true;
                timeduration = 0;
            }
        }
    }
}
