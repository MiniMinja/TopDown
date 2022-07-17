# SwordAttackBehavior
### GeneralAttackBehaviour

[back to Table of Contents](/TableOfContents.md)

## Description   
this script defines the motion and damage of a sword attack.

## Data

### Protected

`PlayerDataRegistry pd`  
the player's data

### Public

`float angleOffset()`  
the angle a sword's swing covers


## Function

### Private

### Protected

`override void start()`  
intializes variables above.

`override void Update()`   
transforms the rotation of a sword swing based on the direction and angle.

`void onTriggerEnter2D(Collider2D collision)`  
when the sword's hitbox collides with an object, the targeted object loses health based on the character's `attackPower` ([CharacterData](/Assets/Scripts/Character/CharacterData.md))