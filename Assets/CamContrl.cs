using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamContrl : MonoBehaviour

{
    public Camera thirdPersonCamera;
    public Camera firstPersonCamera;

    void Start()
    {
        thirdPersonCamera.enabled = false;
        firstPersonCamera.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleCameras();
        }
    }

    void ToggleCameras()
    {
        thirdPersonCamera.enabled = !thirdPersonCamera.enabled;
        firstPersonCamera.enabled = !firstPersonCamera.enabled;
    }
}

