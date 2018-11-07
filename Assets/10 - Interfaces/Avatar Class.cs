using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarClass : MonoBehaviour, IKillable, IDamageable<float>
{
    //The required method of the IKillable interface
    public void kill()
    {
        //Do something fun
    }

    //The required method of the IDamageable interface
    public void Damage(float damageTaken)
    {
        //Do something fun
    }
}
