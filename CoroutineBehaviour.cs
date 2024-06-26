using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;

    public bool canRun;
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    private TimeData timeData;

    public bool CanRun
    {
        get => canRun;
        set => canRun = value;
    }

    public void Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        timeData = ScriptableObject.CreateInstance<TimeData>();
        startEvent.Invoke();
    }


    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    
    private IEnumerator Counting()
    {
        startCountEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfsObj;
            UpdateTimeData();
            repeatUntilFalseEvent.Invoke();
        }
    }

    private void UpdateTimeData()
    {
        timeData.seconds++;
        if (timeData.seconds >= 60)
        {
            timeData.seconds = 0;
            timeData.minutes++;
        }

        if (timeData.minutes >= 60)
        {
            timeData.minutes = 0;
            timeData.hours++;
        }
    }
}