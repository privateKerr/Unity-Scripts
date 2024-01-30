using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]

public class Vector3DataTest : ScriptableObject
{
    public Vector3 value;

    public void UpdateValue(Transform obj)
    {
         value = obj.position;
    }

    public void UpdatePosition(Transform obj)
    {
        obj.localPosition = value;
    }
}
