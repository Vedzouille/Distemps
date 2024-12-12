using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClick : MonoBehaviour
{
    public void Start()
    {
        Debug.Log($"Auto click = {AutoClickCount}");
    }
    public float AutoClickCount = 0f;
    public float Multiplier = 1.25f;
    public Timer timer;

    void Update()
    {
        timer.CurrentTime += Time.deltaTime * AutoClickCount;
    }

    public void MultiplierAutoClick()
    {
        if (AutoClickCount == 0)
        {
            AutoClickCount = 1;
            Debug.Log("auto click set a 1");
        }
        else
        {
            AutoClickCount *= Multiplier;
            AutoClickCount = Mathf.Round(AutoClickCount * 100.0f) * 0.01f;
            Debug.Log($"Auto click = {AutoClickCount}");
        }
    }
}
