using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ObjectScripts : MonoBehaviour
{
    public static float newJump;

    public GameObject SlimeBox;

    public GameObject FirstHint;

    public static Rigidbody rb;

    public GameObject SecondHint;

    public GameObject Respawn;

    float lavaTime = 30f;

    public static int CountLava = 5;

    Text counting;

    public GameObject TestHint;

    public GameObject TestHint2;

    public GameObject TestHint3;

    public GameObject TestHint4;

    public GameObject ifSoDo;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        PlayerMovement.OnGround = true;

        counting = GetComponent<Text>();
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

            Debug.Log("Test Respawn");

            Debug.Log("This is");

            Debug.Log("A");

            Debug.Log("Respawn");
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

    void LavaCountdown()
    {
        counting.text = "Lava will kill you in " + CountLava;
    }

    void TestHintYeet()
    {
        if (TestHint.activeSelf == true)
        {
            TestHint2.SetActive(true);
        }
    }

    void IfSoHint()
    {
        if (TestHint3.activeSelf == true)
        {
            TestHint4.SetActive(false);
        }
    }

    void DoSo()
    {
        if (ifSoDo.activeSelf == false)
        {
            gameObject.SetActive(true);

            Debug.Log("Finishedd");
        }

    }
}
