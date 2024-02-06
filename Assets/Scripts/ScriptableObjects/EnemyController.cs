using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private EnemyData EnemyData;

    // Start is called before the first frame update
    void Start()
    {
        print(EnemyData.EnemyName1 + " has " + EnemyData.EnemyHealth1 + " health.");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            EnemyData.Attacked(10);
            print(EnemyData.EnemyName1 + " has " + EnemyData.EnemyHealth1 + " health.");
        }
    }
}
