using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass : MonoBehaviour
{
    //This hides the Humanoid version.
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}
