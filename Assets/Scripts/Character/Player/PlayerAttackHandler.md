# PlayerAttackHandler
### MonoBehaviour

[back to Table of Contents](/TableOfContents.md)

## Description  
this script defines how the player activates its attacks.

## Data

### Public

`CharacterData charData`  
[CharacterData](/Assets/Scripts/Character/CharacterData.md)

### Private

`string weaponChoices`  
holds the "key" to 2 types of weapons. [Sword](/Assets/Scripts/Weapon/Sword/SwordAttackBehavior.md) and gun.

`int currWeaponIndex`  
the current weapon the user has equipted

`bool pauseRotate`  
boolean function if the user is allowed to switch weapons.

`WeaponHitBoxActivator activator`  
activates the weapon's hitbox.

`bool timeout`  
boolean function if the user can use a weapon

`float timeduration`  
the duration of an attack

## Function

### Public

`void RotateWeapon()`  
decides which weapon to swap depending on the `currWeaponIndex`.

### Private 

`void Start()`  
creates a secondhand activator that chooses a weapon with hitbox when 

`void Update()`  
 updates the user's cooldown to attack and switch weapons every frame.