using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AutoClick : MonoBehaviour
{
    private ClockDataReader clockDataReader;
    public void Start()
    {
        Debug.Log($"Auto click = {AutoClickCount}");
        clockDataReader = gameObject.GetComponent<ClockDataReader>();
    }
    public float AutoClickCount = 0f;
    public float Multiplier = 1.15f;
    public Timer timer;
    public float Price =100f;
    public float MultiplierPrice = 1.10f;

    void Update()
    {
        if (clockDataReader.ActualLoaded != null)
        {
            timer.CurrentTime += Time.deltaTime * AutoClickCount * clockDataReader.ActualLoaded.AutoClickMultiplier;
        }
        else
        {
            timer.CurrentTime += Time.deltaTime * AutoClickCount;
        }
    }

    public void MultiplierAutoClick()
    {
        if (timer.CurrentTime > Price)
        {

            if (AutoClickCount < 2)
            {
                AutoClickCount += 1;
                Debug.Log("auto click a ajouter 1");
            }
            else
            {
                AutoClickCount *= Multiplier;
                AutoClickCount = Mathf.Round(AutoClickCount * 100.0f) * 0.01f;
                Debug.Log($"Auto click = {AutoClickCount}");
            }
        }
        else
        {
            Debug.Log("T'a pas assez de temps");
        }
    }
    public void BuyAutoClick()
    {
        if (timer.CurrentTime > Price)
        {
            timer.CurrentTime -= Price;
            Price *= MultiplierPrice;
            Price = Mathf.Round(Price * 100.0f) * 0.01f;
            Debug.Log("achat effectuer");
        }
        else
        {
            Debug.Log("T'a pas assez de temps");
        }
    }
}
