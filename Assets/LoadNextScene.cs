using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public string nextSceneName;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("crush"))
        {
            Invoke("LoadScene", 1f);
            Debug.Log("ssss");        }
    }

    private void LoadScene()
    {
        
            SceneManager.LoadScene(1);
        
    }
}
