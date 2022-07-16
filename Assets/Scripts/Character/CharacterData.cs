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
        if(movementType == "directional")
        {
            movementScript = new DirectionalMovement();
        }
        else if(movementType == "destination")
        {
            movementScript = new DestinationMovement();
        }
        movementScript.SetMovespeed(movespeed);
        Debug.Log("movementScript set to: " + movementScript);
    }
}
