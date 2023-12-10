using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resumegame : MonoBehaviour
{
    // fungi button untuk pause game
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    //fungsi untuk kembali ke game/resume game
    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
