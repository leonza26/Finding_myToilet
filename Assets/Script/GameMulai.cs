using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GameMulai : MonoBehaviour
{
    public VideoPlayer vidPlay;
    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene("MainMenu");

        vidPlay.loopPointReached += videoSelesai;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void videoSelesai(VideoPlayer vidPlay)
    {
        Debug.Log("hore");
        SceneManager.LoadScene("MainMenu");
    }
}
