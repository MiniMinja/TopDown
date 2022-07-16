using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralAttackBehavior : MonoBehaviour
{
    public CharacterData data;
    public float duration;
    public float scale;

    bool deactivateLaunched;
    protected float direction;
    

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {
        if(!deactivateLaunched)
        {
            DestroyInSeconds();
        }
        transform.localScale = new Vector2(scale, scale);
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
        direction = angle;
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
