using UnityEngine;
using UnityEngine.UI;
using System;
public class CalendarManager : MonoBehaviour
{
    public Text calendarText; // Reference to the Text component where you want to display the calendar

    void Start()
    {
        UpdateCalendar();
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
}