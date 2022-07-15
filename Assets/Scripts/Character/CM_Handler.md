# CM_Handler
### MonoBehaviour

[back to Table of Contents](/TableOfContents.md)

## Description
This scripts handles very basic movement from user input (GetAxis()).

## Data

### Public

`float movePower`  
the power of player's movement.

### Private

`Rigidbody2D rb`  
reference to the rigidbody component.

`Vector2 MoveDir`  
the direction of the vector.

## Function

### Public



### Private

`void Start()`  
initializes variables above.

`void Update()`  
defines the `moveDir` variable based on user input.

`void FixedUpdate()`  
defines the movement using `moveDir` and `movePower`.

