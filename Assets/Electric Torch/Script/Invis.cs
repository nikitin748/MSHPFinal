using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invis : MonoBehaviour
{
    void Update()
    {
        // Делаем объект невидимым
        Renderer rend = GetComponent<Renderer>();
        rend.enabled = false;
    }
}
