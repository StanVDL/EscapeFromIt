using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectScripts : MonoBehaviour
{
    public static float newJump;

    public GameObject SlimeBox;

    public GameObject FirstHint;

    public static Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            FirstHint.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector3(0, 150f, 0);
            }
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
