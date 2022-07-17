# PlayerMovement
### Movement

[back to Table of Contents](/TableOfContents.md)

## Description
this script defines the player's movement based on the user's input. 

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
initializes the variables above.

`void Update()`  
every frame, the user's (x,y) directional input creates new [Vector 2 dir](/Assets/Scripts/Character/Movement/DestinationMovement.md) with the magnitude and angle. 

`void FixedUpdate()`  
calculations done in `void Update()` is updated into `data.movementScript`, which commands the `rigidbody2D` to move. 