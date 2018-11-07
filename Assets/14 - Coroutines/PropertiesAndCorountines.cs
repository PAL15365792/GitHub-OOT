using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesAndCorountines : MonoBehaviour
{
    public float smoothing = 7f;
    public Vector3 Target
    {
        get { return Target; }
        set
        {
            Target = value;

            StopCoroutine("Movement");
            StartCoroutine("Movement", Target);
        }
    }


    private Vector3 target;


    IEnumerator Movement (Vector3 target)
    {
        while(Vector3.Distance(transform.position, target) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target, smoothing * Time.deltaTime);

            yield return null;
        }
    }
}
