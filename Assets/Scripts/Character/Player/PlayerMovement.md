# PlayerMovement
### Movement

[back to Table of Contents](/TableOfContents.md)

## Description
this script is a singleton that defines the player's movement.

## Data

### Static

`PlayerMovement instance`   
player's movement throughout it's sole instance

### Public

### Private

`float movepower`   
power of the player's movement

## Function

### Static

`PlayerMovement GetInstance()`
retrieves movement to the sole instance that does not have `PlayerMovement` 

### Public 

`void SetMovePower(float movepower)`   
changes `float movepower` to the object's movepower

`override void Move(Rigidbody 2d)`  
replaces the movement velocity to be direction * movepower. Direction is defined in [Movement](/Assets/Scripts/Character/Movement/Movement.md).