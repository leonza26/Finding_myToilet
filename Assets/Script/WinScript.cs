using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    [SerializeField] GameObject winMenu;
    [SerializeField] public string levelSelanjutnya;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextStage() //untuk tombol next, string levelSelanjutnya diedit di property Canvas
    {
        SceneManager.LoadScene(levelSelanjutnya);
        Debug.Log("ke level selanjutnya" + levelSelanjutnya);
    }

    public void goHome() //untuk tombol home, fungsi disetting di objek buttonnya
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("ke main menu");
    }
}
