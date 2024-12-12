using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

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
        //Debug.Log(CurrentTime.ToString());
    }

    void _UpdateTimerDisplay()
    {
        System.TimeSpan monTS = TimeSpan.FromSeconds((double)CurrentTime);
        TimerText.text = monTS.ToString("dd':'hh':'mm':'ss");
    }
}
