using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviour : MonoBehaviour
{

    private Text label;
    public UnityEvent startEvent;
    
    // Start is called before the first frame update
    private void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
    }

    // Update is called once per frame
    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(StringData obj)
    {
        label.text += obj.value.ToString(CultureInfo.InvariantCulture);
    }
    
    public void UpdateLabel(TimeData obj)
    {
            label.text += obj.hours.ToString("00") + ":"; // Two digits for hours
            label.text += obj.minutes.ToString($"00") + ":"; // Two digits for minutes
            label.text += obj.seconds.ToString("00"); // Two digits for seconds
    }
    
    public void SetLabel(StringData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
}
