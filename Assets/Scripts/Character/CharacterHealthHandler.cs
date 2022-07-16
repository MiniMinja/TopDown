using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealthHandler : MonoBehaviour
{
    public CharacterData data;

    float health;

    void Start()
    {
        health = data.maxHealth;
    }

    void Update()
    {
        if(health <= 0)
        {
            Death();
        }
    }

    public void TakeDamage(float dmg)
    {
        health -= dmg;
        Debug.Log("Health: " + health);
    }

    public void Death()
    {
        Debug.Log("DEAD");
        gameObject.SetActive(false);
    }
}
