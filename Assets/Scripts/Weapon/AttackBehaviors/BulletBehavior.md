# BulletBehavior
### GeneralAttackBehavior

[back to Table of Contents](/TableOfContents.md)

## Description
this script defines the speed, direction, and collision of a bullet.

## Data

### Protected

`PlayerDataRegistry pd`  
the player's data [CharacterData](/Assets/Scripts/Character/CharacterData.md)

### Public 
`float bulletMovespeed`  
the movemenet speed of a bullet

`Rigidbody2D rb`  
reference to the rigidbody component

## Function

### Protected

`override void Start()`
intializes variables above and identifies the player.

`override void Update()`
undefined

### Private

`void FixedUpdate()`
creates vectors for each bullet based on its direction and movement speed.

`void OnTriggerEnter2D (Collider2D collision)`
when the bullet's hitbox collides with an object, the targeted object loses health based on the character's `attackPower` ([CharacterData](/Assets/Scripts/Character/CharacterData.md))