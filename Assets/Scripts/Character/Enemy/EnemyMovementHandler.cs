using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementHandler : MonoBehaviour
{
    
    public CharacterData data;

    GameObject playerRef;

    Rigidbody2D rb;
    DestinationMovement movementScript;

    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");

        rb = GetComponent<Rigidbody2D>();
        movementScript = (DestinationMovement)data.movementScript;
    }

    void Update()
    {
        movementScript.UpdateDestination(playerRef.transform.position);
    }

    void FixedUpdate()
    {
        movementScript.Move(rb);
    }
}
