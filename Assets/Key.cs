using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject door;
    public float rotationAngle = 90f;
    public GameObject text2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
            text2.SetActive(false);
            RotateDoor();
            
        }
    }

    void RotateDoor()
    {
        door.transform.Rotate(new Vector3(0, rotationAngle, 0), Space.Self);
    }
}
