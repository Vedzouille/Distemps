using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiControler : MonoBehaviour
{
    public AutoClick AutoClick;
    public TextMeshProUGUI UiAutoClick;
    void Start()
    {
        UiAutoClick.text = "le prix est de "+AutoClick.Price.ToString();
    }

    public void UpdateTexte()
    {
        UiAutoClick.text = "le prix est de "+AutoClick.Price.ToString();
    }
}
