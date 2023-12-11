using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText; // memanggil komponent TMP
    [SerializeField] TextMeshProUGUI textWaktuSisa; // memanggil komponent TMP
    [SerializeField] GameManager gm; // membuat variabel waktu mundur

    void Start()
    {
        timerText = GameObject.Find("Canvas/TimerText").GetComponent<TextMeshProUGUI>();
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        // membuat analogi jika waktu saat habis game akan berhenti (script dipindahkan ke game manager untuk mempermudah implementasi win dan lose state)
        /*if (waktuMundur > 0)
        {
            waktuMundur -= Time.deltaTime; //set waktu mundur
        }
        else if (gm.waktuDetik < 0) {
            gm.waktuDetik = 0;
            timerText.color = Color.red;
        } */

        int minutes = Mathf.FloorToInt(gm.waktuDetik / 60); //ubah  dari menit ke detik
        int seconds = Mathf.FloorToInt(gm.waktuDetik % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); //tampilkan format waktu seperti string yang kita atur
    }

    public void waktuHabis()
    {
        timerText.color = Color.red;
    }

    public void waktuSisa(float waktu)
    {
        int minutes = Mathf.FloorToInt(waktu / 60); //ubah  dari menit ke detik
        int seconds = Mathf.FloorToInt(waktu % 60);
        int fraction = Mathf.FloorToInt(waktu * 1000);
        fraction = fraction % 1000;
        textWaktuSisa.text = string.Format("{0:00}:{1:00}.{2:000}", minutes, seconds, fraction);
    }
}
