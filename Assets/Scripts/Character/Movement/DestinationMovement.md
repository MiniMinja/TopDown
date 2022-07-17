# DestinationMovement
### Movement

[back to Table of Contents](/TableOfContents.md)

## Description
this script defines an object's movement with a start and destination.

## Data

### Public

### Private
`Vector2 end`  
the end-point of a vector.

## Function

### Public

`override void Move(Ridgidbody2D rb)`  
moves the `Ridgidbody2D rb` with its given vector and velocity.

`void UpdateDestination(Vector2 end)  
replaces the `Vector2 end` with a new destination.