# PlayerDataRegistry
### MonoBehaviour

[back to Table of Contents](/TableOfContents.md)

## Description   
this script defines the movemnt of the camera based on the user's input. 
## Data

### Public

`Camera cam`  
specific perspective or view of the game.

### Private

`float direction`  
where the camera view is moving to.

## Function

### Public

`float GetDirection()`  
retrives the direction the camera is going to move.

### Private

`void Start()`  
initializes the variables above.

`void Update()`  
every frame, [Vector2 dir](/Assets/Scripts/Character/Player/PlayerMovement.md) is updated with a new directions.