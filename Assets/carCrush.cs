using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carCrush : MonoBehaviour
{
    public AudioSource crushSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("crush"))
        {
            crushSound.Play();
            Debug.Log("Crushed");
        }
    }

}
