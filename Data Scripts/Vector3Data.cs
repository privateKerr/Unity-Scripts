using UnityEngine;

[CreateAssetMenu(menuName = "Vector 3 Data/Vector3 Data")]

public class Vector3Data : ScriptableObject
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
