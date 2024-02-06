using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private List<Weapon> weapons;

    // Start is called before the first frame update
    void Start()
    {
        weapons.Add(new Gun());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
