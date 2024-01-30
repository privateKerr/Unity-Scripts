using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ParticleTriggerEvent : MonoBehaviour
{
	public UnityEvent triggerEnterEvent, triggerStayEvent, triggerExitEvent;

	private void OnTriggerEnter()
	{
		triggerEnterEvent.Invoke();
	}

	private void OnTriggerStay()
    {
        triggerStayEvent.Invoke();
    }

    public void OnTriggerExit()
    {
        triggerExitEvent.Invoke();
    }
}
