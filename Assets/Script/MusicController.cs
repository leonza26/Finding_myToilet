using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{

    public Slider asVolumeMusik;
    public AudioSource asMusik;
    [SerializeField] AudioClip lagunya;
    // Start is called before the first frame update
    void Start()
    {
        asMusik = GameObject.Find("BGM").GetComponent<AudioSource>();
        asVolumeMusik.value = asMusik.volume;
        if(asMusik.clip != lagunya)
        {
            asMusik.clip = lagunya;
            asMusik.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void VolumeMusik()
    {
        asMusik.volume = asVolumeMusik.value;
    }
}
