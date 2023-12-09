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

    private float waktuSelesai; //untuk mencatat waktu selesai levelnya
    bool apakahMenang = false;

    // Start is called before the first frame update
    void Start()
    {
        timer = FindObjectOfType<TimerText>(); //membuat referensi TimerText di timer
        player = FindObjectOfType<PlayerController>(); //membuat referensi PlayerController di player
    }

    // Update is called once per frame
    void Update()
    {
        hitungWaktu(); //menghitung mundur time limit (copyan dari script TimerText sebelumnya)
    }

    void hitungWaktu()
    {
        if(!apakahMenang) 
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
    }

    public void GameWin() //dipanggil ketika player menyentuh trigger finishline
    {
        apakahMenang = true;
        waktuSelesai = waktuDetik;
        Debug.Log("Hore kelar, waktu: " + waktuSelesai.ToString());
        player.gameObject.SetActive(false);
        winScreen.gameObject.SetActive(true);
    }

    public void kurangTambahTimer(float berapa) //dipanggil di objek lain (ItemPickup.cs)
    {
        waktuDetik = waktuDetik + berapa;
    }
}
