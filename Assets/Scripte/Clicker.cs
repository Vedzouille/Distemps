using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public float HitPower = 1f;
    
    public Timer Timer;

    public void Hit()
    {
        if (Timer != null)
        {
            Timer.CurrentTime += HitPower;
            Debug.Log("Ajout d'une seconde");
        }
        else
        {
            Debug.Log("Aucune référence au Timer n'a été définie !");
        }
    }
}