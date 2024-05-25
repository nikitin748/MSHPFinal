using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveButton : MonoBehaviour
{
    public Button saveButton;
    public GameManager gameManager;

    void Start()
    {
        // ��������� ��������� ������� �� ������
        saveButton.onClick.AddListener(OnSaveButtonClick);
    }

    void OnSaveButtonClick()
    {
        // ��������� �������� ����� GameManager
        gameManager.SaveProgress();
    }
}
