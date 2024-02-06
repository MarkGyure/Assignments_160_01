/*****************************************************************************
// File Name : Fruit.cs
// Author : Mark Gyure
// Creation Date : 1/25/24
//
// Brief Description : Fruit class contains name, color, and weight of the fruit 
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit //removed MonoBahvior to make our own class
{
    // removed Start and Update, because they inherit from MonoBehavior

    public string name;
    public string color;
    public float weight;

    //creating constructor
    //constructor must have same name as class


    /// <summary>
    /// Constructor for fruit class that takes 3 parameters
    /// </summary>
    /// <param name="name">name of fruit</param>
    /// <param name="c">color of fruit</param>
    /// <param name="w">weight of fruit</param>
    public Fruit(string name, string c, float w)
    {
        this.name = name; //refers to class GLOBALLY. will access the variable at the very top, and then sets that to the "name" put after the equals sign
        color = c;
        weight = w;
    }
    /// <summary>
    /// 
    /// </summary>
    public Fruit()
    {
        name = "banana";
        color = "blue";
        weight = 3.7f;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    public Fruit(string name)
    {
        this.name = name;
        color = "pink";
        weight = 1.0f;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="weight"></param>
    public Fruit(float weight)
    {
        name = "watermelon";
        color = "green";
        this.weight = weight;     //THIS refers to the variable declared originally at the top of the class
    }

    //need one destructer per CLASS
    /// <summary>
    /// 
    /// </summary>
    ~Fruit()
    {
        //maybe write to a file
        //most of the time resetting
        name = "";
        weight = 0f;
        color = "clear";
    }
}
