using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralAttackBehavior : MonoBehaviour
{
    public float duration;
    public float scale;

    bool deactivateLaunched;

    protected PlayerDataRegistry pd;

    protected float direction;

    protected virtual void Start()
    {
        pd = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDataRegistry>();
    }

    protected virtual void Update()
    {
        if(!deactivateLaunched)
        {
            SetDirection(pd.GetDirection());
            DestroyInSeconds();
        }
        transform.localScale = new Vector2(scale, scale);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Attacked!!!");
    }

    protected virtual void OnTriggerExit2D(Collider2D collision)
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
