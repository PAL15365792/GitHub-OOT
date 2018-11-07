using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Member variables can be referred to as fields
    private int experience;

    //Experience is a basic property
    public int Experience
    {
        get
        {
            //Some other code
            return experience;
        }
        set
        {
            //Some other code
            experience = value;
        }
    }

    //Level is a property that converts experience
    //Points into the level of a player automatically
    public int level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    //This is an example of an auto-implemented property
    public int Health { get; set; }
}