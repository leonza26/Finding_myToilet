using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText; // memanggil komponent TMP
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
}
