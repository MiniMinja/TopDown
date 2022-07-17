# EnemyAttackBehavior
### GeneralAttackBehavior

[back to Table of Contents](/TableOfContents.md)

## Description
this script defines the general principles of an enemy' attack

## Data

### Protected
`EnemyMovementHandler movementScript`  
the movement speed of an enemy ([CharacterData](/Assets/Scripts/Character/CharacterData.md))

`float angle`  
the angle of which an enemy's attack comes from

## Function

### Protected
`override void start()`  
initialized the variables above

`override void update()` 
a rotation of the z axis based on `float angle` variable. 

`void OnTriggerEnter2D(Collider2D collision)`  
if the enemy's attack `Collider2D` collides with the player's hitbox, the player's health is reduced based on the enemy's attackPower ([CharacterData](/Assets/Scripts/Character/CharacterData.md))

`void SetAttackDirection (float dir)`  
sets the angle of the enemy attack based on its direction.