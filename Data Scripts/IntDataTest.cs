using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu]
public class IntDataTest : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void CompareValue(IntDataTest obj)
    {
        if (value >= obj.value)
        {
            
        }
        else
        {
            value = obj.value;
        }
    }
    
    public void UpdateValue(int num)
    {
        value += num;
    }

    public void SetValue(IntDataTest obj)
    {
        value = obj.value;
    }

}