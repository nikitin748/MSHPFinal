using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private const string ProgressKey = "GameProgress";
    private static bool isInitialLoad = true;
    private static bool isInitialLoad1 = true;

    void Start()
    {
        // Проверяем, есть ли сохраненный прогресс
        if (PlayerPrefs.HasKey(ProgressKey) )
        {
            if (isInitialLoad1)
            {
                isInitialLoad1 = false;
                SceneManager.LoadScene(1);
            }
        }
        else
        {
            // Если прогресса нет, загружаем сцену 0, но только если это первый запуск
            if (isInitialLoad)
            {
                isInitialLoad = false;
                SceneManager.LoadScene(0);
            }
        }
    }

    public void SaveProgress()
    {
        // Сохраняем прогресс
        PlayerPrefs.SetInt(ProgressKey, 1);
        PlayerPrefs.Save();
    }
}

