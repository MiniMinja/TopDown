using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementHandler : MonoBehaviour
{

    public CharacterData data;

    PlayerDataRegistry pd;

    Rigidbody2D rb;
    DirectionalMovement movementScript;

    void Start()
    {
        pd = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDataRegistry>();

        rb = GetComponent<Rigidbody2D>();
        movementScript = (DirectionalMovement)data.movementScript;
    }

    void Update()
    {
        float xVal = Input.GetAxisRaw("Horizontal");
        float yVal = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(xVal, yVal);
        float angle = Mathf.Atan2(dir.y, dir.x);
        movementScript.SetThrottle(dir.magnitude);
        movementScript.UpdateDirection(angle);
    }

    void FixedUpdate()
    {
        data.movementScript.Move(rb);
    }
}
