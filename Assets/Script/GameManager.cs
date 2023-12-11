using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TimerText timer; //deklarasi objek script TimerText
    [SerializeField] private PlayerController player; //deklarasi objek script PlayerController
    [SerializeField] public float waktuDetik; //untuk timernya

    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;

    private float waktuSelesai; //untuk mencatat waktu selesai levelnya
    bool apakahGameSelesai = false;

    // Start is called before the first frame update
    void Start()
    {
        timer = FindObjectOfType<TimerText>(); //membuat referensi TimerText di timer
        player = FindObjectOfType<PlayerController>(); //membuat referensi PlayerController di player
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        hitungWaktu(); //menghitung mundur time limit (copyan dari script TimerText sebelumnya)
    }

    void hitungWaktu()
    {
        if(!apakahGameSelesai) 
        {
            if (waktuDetik > 0)
            {
                waktuDetik -= Time.deltaTime;
            }
            else if (waktuDetik < 0)
            {
                GameOver(); //memanggil fungsi GameOver bila waktu habis
            }
        }
    }

    void GameOver() //fungsi gameover
    {
        waktuDetik = 0;
        timer.waktuHabis();
        loseScreen.SetActive(true);
        player.gameObject.SetActive(false);
    }

    public void GameWin() //dipanggil ketika player menyentuh trigger finishline
    {
        apakahGameSelesai = true;
        waktuSelesai = waktuDetik;
        player.gameObject.SetActive(false);
        winScreen.SetActive(true);
        timer.waktuSisa(waktuSelesai);
    }

    public void kurangTambahTimer(float berapa) //dipanggil di objek lain (ItemPickup.cs)
    {
        waktuDetik = waktuDetik + berapa;
    }
}
