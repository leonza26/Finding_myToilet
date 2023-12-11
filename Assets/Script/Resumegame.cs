using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resumegame : MonoBehaviour
{
    [SerializeField] GameObject resumeMenu;
    [SerializeField] Animator anim;
    [SerializeField] public string levelSelanjutnya;

    // fungsi button untuk pause game
    public void PauseGame()
    {
        resumeMenu.SetActive(true);
        anim.SetBool("IsOpen", true);
        //Time.timeScale = 0f;
    }

    //fungsi untuk kembali ke game/resume game
    public void ResumeGame()
    {
        anim.SetBool("IsOpen", false);
        //Time.timeScale = 1.0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NextStage() //untuk tombol next, string levelSelanjutnya diedit di property Canvas
    {
        SceneManager.LoadScene(levelSelanjutnya);
    }
}
