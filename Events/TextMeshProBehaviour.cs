using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TextMeshProBehaviour : MonoBehaviour
{
    private TextMeshProUGUI label;
    public UnityEvent startEvent;
    
    // Start is called before the first frame update
    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
    }

    // Update is called once per frame
    public void UpdateLabel(FloatDataTest obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntDataTest obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
}
