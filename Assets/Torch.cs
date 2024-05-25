using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public GameObject light;
    public GameObject text1;
    private void OnCollisionEnter(Collision collision1)
    {
        if (collision1.gameObject.CompareTag("Torch"))
        {
            Destroy(collision1.gameObject);
            light.SetActive(true);
        }
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            text1.SetActive(false);
            
        }
    }


}
