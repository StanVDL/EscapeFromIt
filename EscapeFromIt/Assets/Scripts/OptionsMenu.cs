using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public void BackButton()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Fullscreen(bool IsFullscreen)
    {
        Screen.fullScreen = IsFullscreen;
    }

    public void QuitButton()
    {
        Debug.Log("QUIT");

        Debug.Log("YEET");

        Debug.Log("QUITED");

        Debug.Log("Test");

        Application.Quit();
    }
}
