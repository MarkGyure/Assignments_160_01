using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon 
{
    //protected so child classes can see them
    private string weaponName;
    private int weaponStrength;

    protected int WeaponStrength { get => weaponStrength; set => weaponStrength = value; }
    protected string WeaponName { get => weaponName; set => weaponName = value; }

    //virtual allows child class to copy, or override this class
    protected virtual void TakeDamage( int damage)
    {
        WeaponStrength -= damage;//weaponStrength = weaponStregth - damage
    }
}
