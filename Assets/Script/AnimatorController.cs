using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    [SerializeField] private Animator animator;


    public void Open()
    {
        animator.SetBool("IsOpen", true);
    }

    public void Close()
    {
        animator.SetBool("IsOpen", false);
    }
}
