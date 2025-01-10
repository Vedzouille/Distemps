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

    private ClockDataReader clockDataReader;

    void Start()
    {
        clockDataReader = gameObject.GetComponent<ClockDataReader>();
        CurrentTime = InitialTime;
        _UpdateTimerDisplay();
    }

    void Update()
    {
        if (CurrentTime > 0)
        {
            if (clockDataReader.ActualLoaded != null)
            {
                CurrentTime -= Time.deltaTime * clockDataReader.ActualLoaded.TimeSpeed;
                _UpdateTimerDisplay();
            }
            else
            {
                CurrentTime -= Time.deltaTime;
                _UpdateTimerDisplay();
                Debug.LogWarning("ActualLoaded pas trouver");
            }
        }
    }


    void _UpdateTimerDisplay()
    {
        System.TimeSpan monTS = TimeSpan.FromSeconds((double)CurrentTime);
        TimerText.text = monTS.ToString("dd':'hh':'mm':'ss");
    }
}
