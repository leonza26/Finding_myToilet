using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{

    public Slider asVolumeMusik;
    public Slider asVolumeSound;

    public AudioSource asMusik;
    public AudioSource asSoundPlayer;
    public AudioSource asSoundManager;

    [SerializeField] AudioClip lagunya;

    // Start is called before the first frame update
    void Start()
    {
        asMusik = GameObject.Find("BGM").GetComponent<AudioSource>();

        if(GameObject.Find("Manager/Player/Player") == null)
        {
            
        }
        else
        {
            asSoundPlayer = GameObject.Find("Manager/Player/Player").GetComponent<AudioSource>();
            asSoundManager = GameObject.Find("GameManager").GetComponent<AudioSource>();
        }

        asVolumeMusik.value = asMusik.gameObject.GetComponent<audioSetting>().musicVolume;
        asVolumeSound.value = asMusik.gameObject.GetComponent<audioSetting>().soundVolume;

        if (asMusik.clip != lagunya)
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
        asMusik.gameObject.GetComponent<audioSetting>().musicVolume = asVolumeMusik.value;
        asMusik.volume = asVolumeMusik.value;
    }

    public void VolumeSound()
    {
        asMusik.gameObject.GetComponent<audioSetting>().soundVolume = asVolumeSound.value;
        if(asSoundPlayer != null || asSoundManager != null)
        {
            asSoundPlayer.volume = asVolumeSound.value;
            asSoundManager.volume = asVolumeSound.value;
        }
    }
}
