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
        // ���������, ���� �� ����������� ��������
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
            // ���� ��������� ���, ��������� ����� 0, �� ������ ���� ��� ������ ������
            if (isInitialLoad)
            {
                isInitialLoad = false;
                SceneManager.LoadScene(0);
            }
        }
    }

    public void SaveProgress()
    {
        // ��������� ��������
        PlayerPrefs.SetInt(ProgressKey, 1);
        PlayerPrefs.Save();
    }
}

