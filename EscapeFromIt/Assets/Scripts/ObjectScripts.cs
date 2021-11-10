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
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Main");
        }
    }

    void JumpingSlime()
    {
        rb.velocity = new Vector3(0, 550f, 0);
    }
}
