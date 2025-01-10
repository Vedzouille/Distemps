using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiControler : MonoBehaviour
{
    public AutoClick AutoClick;
    public LevelLoader LevelLoader;
    public Clicker Clicker;
    public TextMeshProUGUI UiAutoClick;
    public TextMeshProUGUI UiLevelLoader;
    public TextMeshProUGUI UiClickUpgrade;

    void Start()
    {
        UpdateTexte();
    }

    void Update()
    {
        UpdateTexte();
    }

    public void UpdateTexte()
    {
        //AutoClick
        int totalSecondsAutoClick = Mathf.FloorToInt(AutoClick.Price);
        int minutesAutoClick = totalSecondsAutoClick / 60;
        int secondsAutoClick = totalSecondsAutoClick % 60;
        UiAutoClick.text = $"Upgrade de l'auto Click possible a {minutesAutoClick:00}:{secondsAutoClick:00}";

        //LevelLoader
        int totalSecondsLevel = Mathf.FloorToInt(LevelLoader.Price);
        int minutesLevel = totalSecondsLevel / 60;
        int secondsLevel = totalSecondsLevel % 60;
        UiLevelLoader.text = $"Niveau suivant disponible a {minutesLevel:00}:{secondsLevel:00}";

        //ClickUpgrade
        int totalSecondsClick = Mathf.FloorToInt(Clicker.HitPowerPrice);
        int minutesClick = totalSecondsClick / 60;
        int secondsClick = totalSecondsClick % 60;
        UiClickUpgrade.text = $"Niveau suivant disponible a {minutesClick:00}:{secondsClick:00}";
    }
}