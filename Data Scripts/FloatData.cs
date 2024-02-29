using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Single Variable Data/Float Data")]
public class FloatData : ScriptableObject
{
    public float value;
    
    public UnityEvent UpdateValueEvent;
    
    public void UpdateValue(float number)
    {
        value += number;
        UpdateValueEvent.Invoke();
    }

    public void ReplaceValue(float number)
    {
        value = number;
    }

    public void DisplayImage(Image img)
    {
        img.fillAmount = value;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
}