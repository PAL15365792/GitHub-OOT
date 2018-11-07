using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the base class which is
//also known as the Parent class.
public class Fruit
{
    public string colour;

    //This is the first constructor for the fruit class
    //and is not inherited by any derived classes.
    public Fruit()
    {
        colour = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    //This is the second constructor for the fruit class
    //and is not inherited by any derived classes.
    public Fruit(string newColour)
    {
        colour = newColour;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + colour + "fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}