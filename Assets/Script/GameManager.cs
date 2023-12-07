using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TimerText timer; //deklarasi objek script TimerText
    [SerializeField] private PlayerController player; //deklarasi objek script PlayerController
    [SerializeField] public float waktuDetik;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Canvas").GetComponent<TimerText>(); //membuat referensi TimerText di timer
        player = GameObject.Find("Manager/Player/Player").GetComponent<PlayerController>(); //membuat referensi PlayerController di timer
    }

    // Update is called once per frame
    void Update()
    {
        //menghitung mundur time limit (copyan dari script TimerText sebelumnya)
        if(waktuDetik >= 0)
        {
            waktuDetik -= Time.deltaTime;
        }
        else
        {
            GameOver(); //memanggil fungsi GameOver bila waktu habis
        }
    }

    void GameOver() //fungsi gameover
    {
        waktuDetik = 0;
        timer.waktuHabis();
    }

    public void kurangTambahTimer(float berapa) //dipanggil di objek lain (ItemPickup.cs)
    {
        waktuDetik = waktuDetik + berapa;
    }
}
