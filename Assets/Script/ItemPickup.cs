using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] GameManager buatTimer; //buat script timer di canvas
    [SerializeField] PlayerController buatPlayer; //buat script playercontroller

    private void Start()
    {
        buatTimer = FindObjectOfType<GameManager>();
        buatPlayer = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D collision) //jalan pas item disentuh
    {
        if(collision.gameObject.tag == "Player") //kalo yang nyentuh player,
        {
            switch (this.gameObject.tag) //cek tagnya item
            {
                case "Debuff Cabe":
                    buatTimer.kurangTambahTimer(-15f, 1); //kalo tagnya cabe, waktu berkurang 15 detik
                    break;
                case "Debuff Seblak":
                    buatTimer.kurangTambahTimer(-30f, 2);  //kalo tagnya seblak, waktu berkurang 30 detik
                    break;
                case "Buff Time":
                    buatTimer.kurangTambahTimer(10f, 0);  //kalo tagnya buff waktu, waktu bertambah 10 detik
                    break;
                case "Buff Speed":
                    buatPlayer.buffCepat(); //kalo tagnya buff speed, manggil fungsi yang ada di PlayerController
                    break;
            }
            this.gameObject.SetActive(false); //menonaktifkan item pickupnya
        }
    }
}
