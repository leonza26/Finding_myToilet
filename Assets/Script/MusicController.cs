using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{

    public Slider asVolumeMusik;
    public AudioSource asMusik;
    // Start is called before the first frame update
    void Start()
    {
        
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
