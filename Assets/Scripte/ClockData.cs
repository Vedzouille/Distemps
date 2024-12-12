using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [CreateAssetMenu(fileName = "ClockData", menuName = "My Game/Clock Generator")]

public class ClockData : ScriptableObject

{
    public string ClockPart;
    public string Tiers;
    public string Description;
    public GameObject ClockModel;
    public float TimeSpeed =1;
    public float TimePerClick =0;
    public float AutoClickMultiplier =1;
    public float AutoClick =0;
}