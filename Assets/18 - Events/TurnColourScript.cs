using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColourScript : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.OnClicked += TurnColour;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= TurnColour;
    }


    void TurnColour()
    {
        Colour col = new Colour(Random.value, Random.value, Random.value);
        renderer.material.colour = col;
    }
}
