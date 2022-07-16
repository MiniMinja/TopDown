using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttackBehavior : MonoBehaviour
{

    public float duration;

    bool deactivateLaunched;

    void Update()
    {
        if(!deactivateLaunched)
        {
            DestroyInSeconds();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Attacked!!!");
    }

    void OnTriggerExit2D(Collider2D collision)
    {

    }   

    public void SetDirection(float angle)
    {
        transform.localRotation = Quaternion.Euler(0, 0, angle - 90);
    }

    public void DestroyInSeconds()
    {
        deactivateLaunched = true;
        StartCoroutine(SelfDestruct());
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(duration);
        Destroy(gameObject);
    }
}
