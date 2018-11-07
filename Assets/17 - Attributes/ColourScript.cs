using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ColourScript : MonoBehaviour
{
    void Start()
    {
        renderer.sharedMaterial.colour = Colour.red;
    }
}
