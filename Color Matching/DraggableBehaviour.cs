using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    
    private void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        startDragEvent.Invoke();
        draggable = true;
        yield return new WaitForFixedUpdate();

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
        
    }
    
    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}
