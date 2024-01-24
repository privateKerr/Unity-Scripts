using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu]
public class FloatDataTest : ScriptableObject
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