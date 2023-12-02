using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] MonoBehaviour TimerText; //buat script timer di canvas
    [SerializeField] MonoBehaviour scriptnyaPlayer; //buat script playercontroller

    private void OnTriggerEnter2D(Collider2D collision) //jalan pas item disentuh
    {
        if(collision.gameObject.tag == "Player") //kalo yang nyentuh player,
        {
            switch (this.gameObject.tag) //cek tagnya item
            {
                case "Debuff Cabe": 
                    TimerText.SendMessage("kurangTambahTimer", -15f); //kalo tagnya cabe, waktu berkurang 15 detik
                    break;
                case "Debuff Seblak":
                    TimerText.SendMessage("kurangTambahTimer", -30f);  //kalo tagnya seblak, waktu berkurang 30 detik
                    break;
                case "Buff Time":
                    TimerText.SendMessage("kurangTambahTimer", 10f);  //kalo tagnya batu/buff waktu, waktu bertambah 10 detik
                    break;
                case "Buff Speed":
                    scriptnyaPlayer.SendMessage("buffCepat");
                    break;
            }
            this.gameObject.SetActive(false); //menonaktifkan item pickupnya
        }
    }
}
