using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackHandler : MonoBehaviour
{
    public CharacterData ed;

    EnemyAttackActivator attackActivator;
    EnemyMovementHandler movementScript;



    bool setAttackDirection;

    float timer;

    bool attacked;

    float timeSinceLastAttack;

    void Start()
    {
        attackActivator = GetComponent<EnemyAttackActivator>();
        movementScript = GetComponent<EnemyMovementHandler>();
    }

    void Update()
    {
        timeSinceLastAttack += Time.deltaTime;
        if(timeSinceLastAttack > 1 / ed.attackSpeed)
        {
            attacked = false;
        }
        if(timeSinceLastAttack > 0.3)
        {
            movementScript.ResumeMoving();
        }

        if(movementScript.GetDistanceFromPlayer() < 2f)
        {
            if(!setAttackDirection)
            {
                attackActivator.SetDirectionAngle(movementScript.GetDirectionAngle());
                setAttackDirection = true;
            }
            timer += Time.deltaTime;
            if(timer > 1)
            {
                if(!attacked)
                {
                    attackActivator.Activate();
                    movementScript.PauseToAttack();
                    timeSinceLastAttack = 0;
                    attacked = true;
                    timer = 0;
                    setAttackDirection = false;
                }
            }
        }
        else{
            timer = 0;
            setAttackDirection = false;
        }
    }
}
