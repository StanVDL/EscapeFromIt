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

    public GameObject SecondHint;

    public GameObject Respawn;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        PlayerMovement.OnGround = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            FirstHint.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space) && PlayerMovement.OnGround == true)
            {
                JumpingSlime();
            }

            PlayerMovement.OnGround = true;
        }

        if (collision.gameObject.tag != "Enemy")
        {
            FirstHint.SetActive(false);

            PlayerMovement.OnGround = false;
        }

        if (collision.gameObject.tag == "Friendly")
        {
            Debug.Log("Friendly");

            Debug.Log("Is true");

            PlayerMovement.OnGround = true;
        }

        if (collision.gameObject.tag == "Hint1")
        {
            Debug.Log("Go");

            Debug.Log("To");

            Debug.Log("Hint2");

            PlayerMovement.OnGround = true;

            SecondHint.SetActive(true);
        }

        if (collision.gameObject.tag == "Respawn")
        {
            SecondHint.SetActive(false);

            Respawn.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && Respawn.activeSelf == true)
        {
            SceneManager.LoadScene("Main");
        }
    }

    void JumpingSlime()
    {
        rb.velocity = new Vector3(0, 150f, 0);
    }
}
