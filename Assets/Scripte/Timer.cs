using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;

    [Header("Timer Settings")]
    public float InitialTime = 600f;

    public float CurrentTime;

    void Start()
    {
        CurrentTime = InitialTime;
        _UpdateTimerDisplay();
    }

    void Update()
    {
        if (CurrentTime > 0)
        {
            CurrentTime -= Time.deltaTime;
            _UpdateTimerDisplay();
        }
    }

    void _UpdateTimerDisplay()
    {
        int minutes = (int)(CurrentTime / 60);
        int seconds = (int)(CurrentTime % 60);
        TimerText.text = $"{minutes:00}:{seconds:00}";
    }
}
