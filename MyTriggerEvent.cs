using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyTriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerExitEvent, triggerStayEvent;

    public void OnTriggerEnter()
    {
        triggerEnterEvent.Invoke();
    }
    public void OnTriggerExit()
    {
        triggerExitEvent.Invoke();
    }

    private void OnTriggerStay()
    {
        triggerStayEvent.Invoke();
    }
}
