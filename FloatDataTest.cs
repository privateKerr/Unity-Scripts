using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu]
public class FloatDataTest : ScriptableObject
{
    public float value;
    public float minValue;
    public UnityEvent minValueEvent;
    
    public void UpdateValue(float number)
    {
        value += number;
    }

    public void ReplaceValue(float number)
    {
        value = number;
    }

    public void MinValueEvent(float minimum)
    {
        minValue = minimum;
        if (!(value < minValue)) return;
        minValueEvent.Invoke();
        value = minValue;
    }
}