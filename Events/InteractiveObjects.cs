using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractiveObjects : MonoBehaviour
{
    public UnityEvent onClick, mouseHoverEvent;

    private void OnMouseOver()
    {
        mouseHoverEvent.Invoke();
    }

    private void OnMouseDown()
    {
        onClick.Invoke();
    }
}
