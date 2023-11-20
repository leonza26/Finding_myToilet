using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;
    Vector2 move;

    // Update is called once per frame
    void Update()
    {
        //buat cek input di keyboard/controller
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        //buat animasi
        if (move.sqrMagnitude < 0.01) //ngecek kecepatan player, kalo berhenti true, bergerak false
        { 
            anim.speed = 0; //ngebikin animasinya berhenti pas gak gerak
        }
        else
        {
            anim.SetFloat("Horizontal", move.x); //ngeset parameter yang ada di animator
            anim.SetFloat("Vertical", move.y);
            anim.speed = 1;
        }
    }

    private void FixedUpdate() //beda dari void update karna Update ngubahnya perframe komputer, jadi tiap pc bakal beda kecepatannya
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime); //yang bikin karakter gerak, dikali Time.fixedDeltaTime biar lebih stabil gerakannya
    }

    void OnCollisionExit2D(Collision2D colExt) //biar kotaknya berhenti pas gak didorong
    {
        if (colExt.gameObject.tag == "Box")
        {
            colExt.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
