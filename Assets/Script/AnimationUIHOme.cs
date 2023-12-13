using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationUIHOme : MonoBehaviour
{

    [SerializeField] private Animator animator;
   public void Open()
    {
       animator.SetBool("IsOpen", true);
    }

    public void CLose()
    {
       animator.SetBool("IsOpen", false);
    }
}
