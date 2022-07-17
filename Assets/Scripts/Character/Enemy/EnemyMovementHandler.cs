using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementHandler : MonoBehaviour
{
    
    public CharacterData data;

    GameObject playerRef;

    Rigidbody2D rb;
    DirectionalMovement movementScript;

    bool movingTowardsPlayer;

    Vector2 dir;
    float angle;
    float distance;

    bool attacking;

    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");

        rb = GetComponent<Rigidbody2D>();
        movementScript = (DirectionalMovement)data.movementScript;

        movingTowardsPlayer = true;

        attacking = false;
    }

    void Update()
    {
        if(attacking)
        {
            movementScript.SetThrottle(0);
        }
        else{
            dir = (Vector2)playerRef.transform.position - rb.position;
            angle = Mathf.Atan2(dir.y, dir.x);
            distance = dir.magnitude;
            if(distance > 2f)
            {
                movingTowardsPlayer = true;
                movementScript.UpdateDirection(angle);
                movementScript.SetThrottle(1);
            }
            else{
                movingTowardsPlayer = false;
                movementScript.SetThrottle(0);
            }
        }
    }

    public void PauseToAttack()
    {
        attacking = true;
    }

    public void ResumeMoving()
    {
        attacking = false;
    }

    void FixedUpdate()
    {
        movementScript.Move(rb);
    }

    public Vector2 GetDirection()
    {
        return dir;
    }

    public float GetDirectionAngle()
    {
        return angle;
    }

    public float GetDistanceFromPlayer()
    {
        return distance;
    }
}
