using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataRegistry : MonoBehaviour
{

    public Camera cam;
    float direction;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = cam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        direction = Mathf.Atan2(dir.y, dir.x) / Mathf.PI * 180;
    }

    public float GetDirection()
    {
        return direction;
    }
}
