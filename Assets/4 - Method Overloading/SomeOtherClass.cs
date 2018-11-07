using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    void Start ()
    {
        SomeClass myClass = new SomeClass();

        //The specific Add method called will depend on
        //the arguments passed in.
        myClass.Add (1, 2);
        myClass.Add("Hello", "World");
    }
}
