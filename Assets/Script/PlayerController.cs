using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;
    [SerializeField] private RectTransform uiSpeed;
    [SerializeField] private PlayerSoundEffects sfx;

    Vector2 move;
    [SerializeField] private float waktuJadiKenceng = 0f;

    void Start()
    {
        uiSpeed = GameObject.Find("Canvas/barSpeed").GetComponent<RectTransform>();
        sfx = GetComponent<PlayerSoundEffects>();
    }

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
            anim.speed = waktuJadiKenceng > 0 ? 2 : 1; //statement if versi 1 baris, intinya ngecek buff sendalnya buat kecepatan animasi
        }

        //buat ngecek apakah buff sendal masih ada atau enggak
        if (waktuJadiKenceng > 0) //jika buffnya masih ada
        {
            waktuJadiKenceng -= Time.deltaTime; //timer buff sendal dikurangi
            speed = 4f; //kecepatannya jadi 4
            uiSpeed.localScale = new Vector3(1.25f * waktuJadiKenceng / 8, 1.25f, 1f); //ngatur panjang bar yang ngasi tau waktu buff sepatunya, iya pake mtk :)
        }
        else if (waktuJadiKenceng < 0) //jika buffnya tidak ada
        {
            waktuJadiKenceng = 0; //timernya akan tetap 0
            speed = 2f; //kecepatannya menjadi 2
        }

    }

    private void FixedUpdate() //beda dari void update karna Update ngubahnya perframe komputer, jadi tiap pc bakal beda kecepatannya
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime); //yang bikin karakter gerak, dikali Time.fixedDeltaTime biar lebih stabil gerakannya
    }

    public void buffCepat() //dipanggil di objek lain (ItemPickup.cs)
    {
        sfx.ambilSendal();
        uiSpeed.localScale = new Vector3(1.25f, 1.25f, 1f);
        waktuJadiKenceng = 8f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            anim.SetBool("pushing", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            anim.SetBool("pushing", false);
        }
    }
}
