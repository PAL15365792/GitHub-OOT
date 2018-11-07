using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the derived class which is
//also known as the Child class.
public class Apple : Fruit
{
    //This is the first constructor for the Apple class.
    //It calls the parent constructor immediately, even
    //before it runs.
    public Apple()
    {
        //Notice how Apple has access to the public variable
        //colour, which is part of the parent Fruit class.
        colour = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    //This is the second constructor for the Apple class.
    //It specifies which parent constructor will be called
    //using the "base" keyword.
    public Apple(string newColour) : base(newColour)
    {
        //Notice how this constructor doesn't set the colour
        //since the base constructor sets the colour that
        //is passed as an argument.
        Debug.Log("2nd Apple Constructor Called");
    }
}