using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public float HitPower = 1f;
    public AutoClick autoClick;
    public UiControler UiControler;
    public Timer Timer;
    public float HitPowerPrice = 100f;

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
        autoClick.BuyAutoClick();
        UiControler.UpdateTexte();
    }

    public void BuyClickUpgrade()
    {
        if (Timer.CurrentTime > HitPowerPrice)
        {
            if (HitPower < 10)
            {
            HitPower += 1f;
            }
            else
            {
            HitPower *= 1.20f;
            }
            Timer.CurrentTime-=HitPowerPrice;
            HitPowerPrice *=1.2f;
        }

    }
}