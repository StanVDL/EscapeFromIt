using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Test;

    public GameObject Test2;

    public GameObject Test3;

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

    public void SensBar()
    {
        if (Test.activeSelf == true)
        {
            gameObject.SetActive(false);

            Test2.SetActive(true);

            Test3.SetActive(false);
        }
    }

}
