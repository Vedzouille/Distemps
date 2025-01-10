using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{

    [SerializeField] private List<GameObject> levels;
    public int currentLevelIndex = 0;
    public Timer timer;
    public float Price;
    void Start()
    {
        foreach (GameObject level in levels)
        {
                level.SetActive(false);
        }

        levels[currentLevelIndex].SetActive(true);
        Debug.Log("Première image activée.");
    }


    public void LoadNextLevel()
    {
        if(timer.CurrentTime > Price)
        {
        currentLevelIndex++;

        if (currentLevelIndex < levels.Count)
        {
            levels[currentLevelIndex].SetActive(true);
            Debug.Log($"Niveau {currentLevelIndex + 1} activé.");
        }
        else
        {
            Debug.Log("Tous les niveaux sont afficher");
        }
        timer.CurrentTime-= Price;
        Price *= 3;
        }
    }
}
