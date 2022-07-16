using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttackBehavior : GeneralAttackBehaviour
{

    public float angleOffset;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
        transform.localRotation = Quaternion.Euler(0, 0, direction + angleOffset);
    }
}
