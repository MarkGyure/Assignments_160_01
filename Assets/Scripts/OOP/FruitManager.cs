using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public List<Fruit> fruitSalad;//creating a list

    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        fruitSalad = new List<Fruit>(); //defining the fruit salad list and creating a new list of fruits

        Fruit apple = new Fruit("apple","red",1.2f);    //cant be empty, less or more than 3 bc you made Fruit constructor to have 3 parameters
        fruitSalad.Add(apple);  //adds apple the fruit salad list by calling the created list first and then using the . operator 

        CreateFruitSalad();
        DisplayFruitSalad();
    }
    /// <summary>
    /// 
    /// </summary>
    private void DisplayFruitSalad()
    {
        for(int i = 0; i < fruitSalad.Count; i++)
        {
            print(fruitSalad[i].color + " " + fruitSalad[i].name + " weighs " + fruitSalad[i].weight +          //SAME LINE
                "units");                                                                                       //SAME LINE
        }
    }
    /// <summary>
    /// 
    /// </summary>
    private void CreateFruitSalad()
    {
        // fruitSalad.Add(new Fruit());              //this will throw an error that tells you that you cant do this because youre trying to access a function that doesnt allow for 0 parameters, UNLESS CREATED ONE WITH 0
        fruitSalad.Add(new Fruit());

       // fruitSalad.Add(new Fruit("strawberry"));    //this will obv have the same issue until you make a constructor for Fruit that only has 1 variable.
        fruitSalad.Add(new Fruit("strawberry"));

        //fruitSalad.Add(new Fruit(7.8f));            //same issue here, but its a diff error bc we have one that has 1 variable, but it this is a float, and that one is a string so it still has problems.
        fruitSalad.Add(new Fruit(7.8f));
    }
}
