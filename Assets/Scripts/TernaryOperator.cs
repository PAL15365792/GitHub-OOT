﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperator : MonoBehaviour
{
    void start()
    {
        int health = 10;
        string message;

        //This is an example Ternary Operation that chooses a message based
        //on the variable "health".
        message = health > 0 ? "Player is Alive" : "Player is Dead";
    }
}
	

