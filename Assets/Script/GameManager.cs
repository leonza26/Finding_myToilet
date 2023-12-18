using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TimerText timer; //deklarasi objek script TimerText
    [SerializeField] private PlayerController player; //deklarasi objek script PlayerController
    [SerializeField] public float waktuDetik; //untuk timernya

    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;

    [SerializeField] TextMeshProUGUI buatNotif; //buat notifikasi tambah/kurang waktu
    [SerializeField] Animator animNotif; //animatornya notif

    [SerializeField] GameSound gameSound;

    private float waktuSelesai; //untuk mencatat waktu selesai levelnya
    bool apakahGameSelesai = false;

    // Start is called before the first frame update
    void Start()
    {
        timer = FindObjectOfType<TimerText>(); //membuat referensi TimerText di timer
        player = FindObjectOfType<PlayerController>(); //membuat referensi PlayerController di player
        buatNotif = GameObject.Find("Canvas/popUpTimer").GetComponent<TextMeshProUGUI>();
        animNotif = GameObject.Find("Canvas/popUpTimer").GetComponent<Animator>();
        gameSound = GetComponent<GameSound>();
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
        gameSound.audSrc.PlayOneShot(gameSound.lose);
        player.gameObject.SetActive(false);
    }

    public void GameWin() //dipanggil ketika player menyentuh trigger finishline
    {
        apakahGameSelesai = true;
        waktuSelesai = waktuDetik;
        player.gameObject.SetActive(false);
        gameSound.audSrc.PlayOneShot(gameSound.win);
        winScreen.SetActive(true);
        timer.waktuSisa(waktuSelesai);
    }

    public void kurangTambahTimer(float berapa, int suaranya) //dipanggil di objek lain (ItemPickup.cs)
    {
        switch (suaranya)
        {
            case 0:
                gameSound.audSrc.PlayOneShot(gameSound.batu);
                break;
            case 1:
                gameSound.audSrc.PlayOneShot(gameSound.cabe);
                break;
            case 2:
                gameSound.audSrc.PlayOneShot(gameSound.seblak);
                break;
            default:
                break;
        }
        animNotif.Rebind();
        if (berapa > 0)
        {
            buatNotif.text = string.Concat("+", berapa.ToString());
            animNotif.Play("buffAnim");
        }
        else
        {
            buatNotif.text = berapa.ToString();
            animNotif.Play("debuffAnim");
        }
        waktuDetik = waktuDetik + berapa;
    }
}
