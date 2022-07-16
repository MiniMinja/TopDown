# CharacterData
### ScriptableObject

[back to Table of Contents](/TableOfContents.md)

## Description
this script defines the character's attributes.
## Data

### Public 

`float maxHealth`  
the character's maximum health pool.

`float movespeed`   
the character's movement speed.

`float attackPower`  
the amount of damage the character deals per attack.

`float attackSpeed`  
how fast the character attacks per second.

`float tenacity`  
the character's resistance to stuns

`float armor`  
the character's damage mitigation 

`float healthRegen`  
how much the character regenerates health over time (or heals once item is consumed -- undecided)

`string movementType`  
holds the "key" to the 3 types of movements: the movement of [Player](/Assets/Scripts/Character/Player/), Enemy (Not defined yet), and Boss (Not defined yet). Each movementObject keys are "player", "enemy", "boss", respectively.

`Movement movementScript`  
the movement script set by the movementScript
### Private

## Function

### Public

`void OnEnable()`  
this function sets the movementScript as the singleton [PlayerMovement](/Assets/Scripts/Character/Player/PlayerMovement.md). (Does this in the background when you change something) (Also for debugging purposes).