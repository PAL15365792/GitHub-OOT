using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladClass : MonoBehaviour
{
    void Start ()
    {
        Apple myApple = new Apple();

        //Notice that the Apple version of the methods
        //override the fruit versions. Also notice that
        //since the Apple versions called the fruit version with
        //the "base" keyword, both are called.
        myApple.SayHello();
        myApple.Chop();

        //Overriding is also useful in a polymorphic situation.
        //Since the methods of the Fruit class are "virtual" and 
        //the methods of the Apple c;ass are "override", when we
        //upcast an Apple into a Fruit, the Apple version of the
        //Methods are used.
        Fruit myFruit = new Apple();
        myFruit.SayHello();
        myFruit.Chop();
    }
}
