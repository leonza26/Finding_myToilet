using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void Open()
    {
        animator.SetBool("IsOpen", true);
        Time.timeScale = 0f; // Pause game
    }

    public void Close()
    {
        animator.SetBool("IsOpen", false);
        Time.timeScale = 1f; // Kembalikan ke normal
    }
}
