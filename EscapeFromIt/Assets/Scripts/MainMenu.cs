using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitButton()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
}
