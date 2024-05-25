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
        // Добавляем слушатель нажатия на кнопку
        saveButton.onClick.AddListener(OnSaveButtonClick);
    }

    void OnSaveButtonClick()
    {
        // Сохраняем прогресс через GameManager
        gameManager.SaveProgress();
    }
}
