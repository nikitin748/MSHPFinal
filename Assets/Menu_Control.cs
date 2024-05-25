using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Control : MonoBehaviour
{
    public void quit()
    {
        Application.Quit();
    }
    public void ToSettings()
    {
        SceneManager.LoadScene(3);
    }
    public void ToGame()
    {
        SceneManager.LoadScene(2);
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(1);
    }
}
