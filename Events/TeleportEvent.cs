using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TeleportEvent : MonoBehaviour
{
    public UnityEvent onTeleport;
    public Vector3 destination;

    public void Teleport()
    {
        onTeleport.Invoke();
    }
}
