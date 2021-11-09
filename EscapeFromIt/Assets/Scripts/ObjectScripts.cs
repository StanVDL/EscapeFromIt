using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectScripts : MonoBehaviour
{
    public static float newJump;

    public GameObject SlimeBox;

    public GameObject FirstHint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            FirstHint.SetActive(true);
        }

        if (collision.gameObject.tag != "Enemy")
        {
            FirstHint.SetActive(false);
        }

        if (collision.gameObject.tag == "Friendly")
        {
            Debug.Log("Friendly");
            Debug.Log("Is true");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Main");
        }
    }

}
