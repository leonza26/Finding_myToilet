using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundEffects : MonoBehaviour
{
    [SerializeField] private AudioSource audSrc;
    [SerializeField] private AudioClip[] playerEasyJalan;
    [SerializeField] private AudioClip playerEasyDorong;
    [SerializeField] private AudioClip[] playerMedJalan;
    [SerializeField] private AudioClip playerMedDorong;
    [SerializeField] private AudioClip sendal;

    public void jalanEasy()
    {
        audSrc.PlayOneShot(playerEasyJalan[Random.Range(0, playerEasyJalan.Length)]);
    }

    public void jalanMed()
    {
        audSrc.PlayOneShot(playerMedJalan[Random.Range(0, playerMedJalan.Length)]);
    }

    public void dorongEasy()
    {
        audSrc.PlayOneShot(playerEasyDorong);
    }

    public void dorongMed()
    {
        audSrc.PlayOneShot(playerMedDorong);
    }

    public void ambilSendal()
    {
        audSrc.PlayOneShot(sendal);
    }
}
