using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ClockData", menuName = "My Game/Clock Generator")]

public class ClockData : ScriptableObject

{
    public string Description;
    public Sprite ClockModel;
    public float TimeSpeed =1;
    public float TimePerClick =0;
    public float AutoClickMultiplier =1;
    public float AutoClick =0;
}