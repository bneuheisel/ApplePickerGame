using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
    }
    public void Play()
    {
        //SceneManager.LoadScene("SampleScene");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Level1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Space");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Night");
    }
}
