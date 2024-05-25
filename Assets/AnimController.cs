using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    private void Update()
    {
        float _axis = Input.GetAxis("Vertical");
        float _axis2 = Input.GetAxis("Horizontal");
        if (_axis != 0)
        {
            if (_axis > 0)
            {
                animator.SetInteger("Speed", 1);
                if (Input.GetKey(KeyCode.LeftShift) )
                {
                    animator.SetInteger("Speed", 2);
                }
            }
            else
            {
                animator.SetInteger("Speed", -1);
            }
        }
        else
        {
            animator.SetInteger("Speed", 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("RL", 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("RL", 2);
        }
       else
        {
            animator.SetInteger("RL", 0);
        }
        
    }
}
