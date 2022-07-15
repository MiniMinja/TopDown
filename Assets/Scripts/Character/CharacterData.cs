using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName ="CreateCharacterData")]
public class CharacterData : ScriptableObject
{
    public float maxHealth;
    public float movespeed;
    public float attackPower;
    public float attackSpeed;
    public float tenacity;
    public float armor;
    public float healthRegen;

    public string movementType;
    public Movement movementScript;
    
    public void OnEnable()
    {
        if(movementType == "player")
        {
            PlayerMovement pm = PlayerMovement.GetInstance();
            pm.SetMovePower(movespeed);
            movementScript = pm;
        }
        Debug.Log("movementScript set to: " + movementScript);
    }
}
