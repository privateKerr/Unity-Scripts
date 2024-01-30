using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyTriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    public void OnTriggerEnter()
    {
        triggerEnterEvent.Invoke();
    }
}
