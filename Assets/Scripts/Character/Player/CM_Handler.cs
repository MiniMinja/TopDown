using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM_Handler : MonoBehaviour
{
    public float movePower;

    Rigidbody2D rb;

    Vector2 moveDir;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        Move();
    }

    public void Move(){
        rb.velocity = moveDir * movePower;
    }
}
