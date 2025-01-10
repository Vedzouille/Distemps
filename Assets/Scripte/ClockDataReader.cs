using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockDataReader : MonoBehaviour
{
    [SerializeField] public ClockData Level1;
    [SerializeField] public ClockData Level2;
    [SerializeField] public ClockData Level3;
    [SerializeField] public ClockData Level4;
    [SerializeField] public ClockData Level5;
    public ClockData ActualLoaded;
    private List<ClockData> data;
    public Image image;
    private void Start()
    {
        data = new List<ClockData>()
        {
            {Level1}, {Level2}, {Level3}, {Level4}, {Level5}
        };
    }

    public void generatclock()
    {
        var Clockloaded = Random.Range(0, data.Count);
        ActualLoaded = data[Clockloaded];
        image.sprite = ActualLoaded.ClockModel;
    }
}
