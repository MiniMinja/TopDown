# SwordAttackBehavior
### MonoBehavior

[back to Table of Contents](/TableOfContents.md)

## Description
This script defines how the sword attack functions.

## Data

### Public

`float duration`  
the duration of an attack.

### Private

`bool deactivateLaunched`   
boolean for `deactivateLaunched`.


## Function

### Public

`void SetDirection(float angle)`
sets the angle by creating a rotation around the (x,y,z axis)

`void DestroyInSeconds()`
runs a self destruct 

### Private

`void Update()`  
constantly checks if `deactivateLaunched` is true. If true, performs `DestroyInSeconds()` function. 

`void OnTriggerEnter2D(Collider2D Collision)`    
triggered when the collider component comes into contact with another object.

`void OnTriggerExit2D(Collider2D Collision)`  
undefined.

