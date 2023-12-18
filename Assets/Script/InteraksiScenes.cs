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

 // interkasi Visual novel Hometown
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

    public void HometownVn4()
    {
        SceneManager.LoadScene("VisualNovel4");
    }

    public void HometownVn5()
    {
        SceneManager.LoadScene("VisualNovel5");
    }


    //  interkasi Visual novel Office
    public void OfficeVn1()
    {
        SceneManager.LoadScene("VisualNOvelO1");
    }

    public void OfficeVn2()
    {
        SceneManager.LoadScene("VisualNOvelO2");
    }

    public void OfficeVn3()
    {
        SceneManager.LoadScene("VisualNOvelO3");
    }

    public void OfficeVn4()
    {
        SceneManager.LoadScene("VisualNOvelO4");
    }

    public void OfficeVn5()
    {
        SceneManager.LoadScene("VisualNOvelO5");
    }

    public void OfficeVn6()
    {
        SceneManager.LoadScene("VisualNOvelO6");
    }

    public void OfficeVn7()
    {
        SceneManager.LoadScene("VisualNOvelO7");
    }

    public void OfficeVn8()
    {
        SceneManager.LoadScene("VisualNOvelO8");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
