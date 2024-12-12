using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public float HitPower = 1f;
    public AutoClick autoClick;
    public Timer Timer;

    public void Hit()
    {
        if (Timer != null)
        {
            Timer.CurrentTime += HitPower;
            Debug.Log("Ajout de X seconde");
        }

    }
    public void AutoClickHit()
    {
        autoClick.MultiplierAutoClick();
    }
}