using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//bc outside of class, you dont need semi colon
[CreateAssetMenu(fileName = "EnemyData", menuName = "Enemy Data")]

public class EnemyData : ScriptableObject
{
    [SerializeField] private string EnemyName;
    [SerializeField] private string EnemyDescription;
    [SerializeField] private int EnemyHealth;
    [SerializeField] private int EnemyDamage;
    [SerializeField] private float EnemySpeed;

    //to get these, right click variable "Quick actions and refactorings" and encapsulate field.
    public string EnemyName1 { get => EnemyName; set => EnemyName = value; }
    public string EnemyDescription1 { get => EnemyDescription; set => EnemyDescription = value; }
    public int EnemyHealth1 { get => EnemyHealth; set => EnemyHealth = value; }
    public int EnemyDamage1 { get => EnemyDamage; set => EnemyDamage = value; }
    public float EnemySpeed1 { get => EnemySpeed; set => EnemySpeed = value; }

    public void Attacked(int damage)
    {
        EnemyHealth1 -= damage;
        //debug.log bc there is NO MONOBEHAVIOUR
        Debug.Log(EnemyName1 + " has been attacked and has " + EnemyHealth1 + " health left.");
    }
}
