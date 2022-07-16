# CharacterHandler
### MonoBehavior

[back to Table of Contents](/TableOfContents.md)

## Description
this script defines how the character is moved around.
## Data

### Public

`characterData data`   
[CharacterData](/Assets/Scripts/Character/CharacterData.md)

`Rigidbody2d rb`  
reference to the rigidbody component

## Function

`void Start()`  
spawns in `Rigidbody2d rb`

`void Update()`  
defines `Vector2 dir` based on the user's input. `data.movementScript` is updated based on the position's transformation.

`void FixedUpdate()`  
updates the character's movement at a where it corresponds to user's imput 