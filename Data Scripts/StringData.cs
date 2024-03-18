using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Single Variable Data/String Data")]
public class StringData : ScriptableObject
{
    public string value;

    public void SetValue(string input)
    {
        value = input;
    }
}