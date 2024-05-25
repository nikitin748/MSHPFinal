using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textf : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject texta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if (transform.position.z > 340)
        {
            texta.SetActive(false); // отключаем gameobject
            
        }
        else if(transform.position.z > 285)
{
            text1.SetActive(false); // отключаем gameobject
            text2.SetActive(true);
            Debug.Log ("wefwef");
        }
       
    }
}
