using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHandler : MonoBehaviour
{

    public CharacterData data;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 dir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        data.movementScript.Update(transform.position, transform.position + (Vector3)dir);
    }

    void FixedUpdate()
    {
        data.movementScript.Move(rb);
    }
}
