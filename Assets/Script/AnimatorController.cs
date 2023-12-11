using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    //note: gatau kenapa event di animation itu gak nangkep 
    //      skrip-skrip di canvas, cuman nangkep di objeknya 
    //      sendiri, jadi animator controllernya kujadiin aja
    //      buat namba-nambahin fungsi yang dijalanin di 
    //      event animation.

    public void Open()
    {
        
        Time.timeScale = 0f;
    }
    public void Close()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
