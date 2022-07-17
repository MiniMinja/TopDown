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
boolean if the weapon is not attacking

## Function

### Protected

`virtual void Start()`  
intializes variables above.

`virtual void Update()`
runs `deactivateLaunced` boolean and sets a new vector

### Private

`void OnTriggerEnter2D(Collider2D collision)