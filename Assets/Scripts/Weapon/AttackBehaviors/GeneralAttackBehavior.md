# GeneralAttackBehavior.md
### Monobehaviour

[back to Table of Contents](/TableOfContents.md)

## Description
this script defines the general principles of a character's attack
## Data

### Protected
`float direction`  
the weapon's striking direction

### Public
`float duration`  
the time period of an attack

`float scale`  
the magnitude of an attack

### Private

`bool deactivateLaunched`  
boolean function if the weapon is not attacking

## Function

### Protected

`virtual void Start()`  
intializes variables above.

`virtual void Update()`  
runs `deactivateLaunched` boolean and creates a new vector.

### Private

`void OnTriggerEnter2D(Collider2D collision)`  
when the hitbox of a weapon or projectile hits an object.

`void OnTriggerExit2D(Collider2D colliison)`  
Unidentified

### Public
`void SetDirection(float angle)`  
the direction of an attack is based off of an angle. 

`void DestroyInSeconds()`  
initiates the destruction of the attack (`gameObject`) when it is deactivated.

`IEnumerator SelfDestruct`  
After a certain time, the `gameObject` is destroyed. 