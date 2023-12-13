using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteraksiScenes : MonoBehaviour
{
    public void hometown()
    {
        SceneManager.LoadScene("hometown");
    }

    public void office()
    {
        SceneManager.LoadScene("Office");
    }

    public void chooselevel()
    {
        SceneManager.LoadScene("ChooseLevel");
    }

    public void level1easy()
    {
        SceneManager.LoadScene("LevelEasy_1");
    }


    public void Quit()
    {
        Application.Quit();
    }
}
