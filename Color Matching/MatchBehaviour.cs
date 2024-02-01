using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    private ID otherID;

    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if (tempObj == null)
            return;
            
        var otherID = tempObj.idObj;    
        if (otherID == idObj)
        {
            Debug.Log("Matched");
        }
        else
        {
            Debug.Log("No Match");
        }
    }

}
