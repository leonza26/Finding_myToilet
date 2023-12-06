using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText; // memanggil komponent TMP
    [SerializeField] public float waktuMundur; // membuat variabel waktu mundur

    // Update is called once per frame
    void Update()
    {

        // membuat analogi jika waktu saat habis game akan berhenti
        if (waktuMundur > 0)
        {
            waktuMundur -= Time.deltaTime; //set waktu mundur
        }
        else if (waktuMundur < 0) {
            waktuMundur = 0;
            timerText.color = Color.red;
        }

        int minutes = Mathf.FloorToInt(waktuMundur / 60); //ubah  dari menit ke detik
        int seconds = Mathf.FloorToInt(waktuMundur % 60); 
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); //tampilkan format waktu seperti string yang kita atur
    }

    public void kurangTambahTimer(float berapa) //dipanggil di objek lain (ItemPickup.cs)
    {
        waktuMundur = waktuMundur + berapa;
    }
}
