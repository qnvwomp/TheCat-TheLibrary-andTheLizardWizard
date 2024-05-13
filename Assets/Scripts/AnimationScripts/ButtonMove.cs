using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Play the animation
            animator.SetTrigger("ButtonPush");
        }
    }
}
