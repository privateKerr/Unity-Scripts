using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Events;

public class CalendarManager : MonoBehaviour
{
    public Text calendarText; // Reference to the Text component where you want to display the calendar
    public UnityEvent onNewDay;
    private DateTime lastUpdateDate;

    void Start()
    {
        // Initialize lastUpdateDate to the current date
        lastUpdateDate = DateTime.Now.Date;

        UpdateCalendar();
    }

    private void Update()
    {
        if (DateTime.Now.Date != lastUpdateDate)
        {
            // Update lastUpdateDate to the current date
            lastUpdateDate = DateTime.Now.Date;
            NewDay();
        }
    }

    void UpdateCalendar()
    {
        // Get the current date
        DateTime currentDate = DateTime.Now;

        // Format the date as desired
        string formattedDate = currentDate.ToString("MMMM dd, yyyy");

        // Update the calendar text
        calendarText.text = formattedDate;
    }

    void NewDay()
    {
        onNewDay.Invoke();
    }
}