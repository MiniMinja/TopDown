# PlayerMovement
### Movement

[back to Table of Contents](/TableOfContents.md)

## Description
this script is a singleton that defines the player's movement.

## Data

### Public

`CharacterData data`  
[CharacterData](/Assets/Scripts/Character/CharacterData.md)

### Private

`Rigidbody2D rb`   
reference to the rigidbody component

`DirectionalMovement movementScript`  
the character's movements from the user's input

## Function

### Public 

### Private

`void Start()`  
identifies the player and applies `movementScript` to the rigidbody component. 

`void Update()`  
every frame, the user's (x,y) directional input creates new [Vector 2 dir](/Assets/Scripts/Character/Movement/DestinationMovement.md) with the magnitude and angle. 

`void FixedUpdate()`  
with the `data.movementScript`, the `Rigidbody2D rb` is shown moving. 