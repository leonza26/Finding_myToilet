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

    public void level2easy()
    {
        SceneManager.LoadScene("LevelEasy_2");
    }


    public void level3easy()
    {
        SceneManager.LoadScene("LevelEasy_3");
    }

    public void level1Medium()
    {
        SceneManager.LoadScene("LevelMedium_1");
    }

    public void level2Medium()
    {
        SceneManager.LoadScene("LevelMedium_2");
    }

    public void level3Medium()
    {
        SceneManager.LoadScene("LevelMedium_3");
    }


    public void HometownVn1()
    {
        SceneManager.LoadScene("VisualNovel");
    }

    public void HometownVn2()
    {
        SceneManager.LoadScene("VisualNovel2");
    }

    public void HometownVn3()
    {
        SceneManager.LoadScene("VisualNovel3");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
