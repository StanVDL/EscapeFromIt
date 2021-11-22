using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public CharacterController control;

    public float speed = 12f;

    Vector3 velocity;

    public float gravity = -9.81f;

    public Transform groundCheck;

    public float groundDistance = 0.4f;

    public LayerMask groundMask;

    bool isGrounded;

    public float jump;

    bool autoJump = false;

    bool slimeBox = false;

    public GameObject SlimeMessage;

    public GameObject SkipMessage;

    public GameObject AutoHint1;

    public GameObject Hint2;

    public GameObject Yeet1;

    public GameObject Wack1;

    public GameObject Zeb1;

    public GameObject Hop;

    public GameObject Hop2;

    public GameObject YEETER;

    // Start is called before the first frame update
    void Start()
    {
        control.detectCollisions = true;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float xx = Input.GetAxis("Horizontal");

        float zz = Input.GetAxis("Vertical");

        Vector3 move = transform.right * xx + transform.forward * zz;

        control.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        control.Move(velocity * Time.deltaTime);

        if (SkipMessage.activeSelf == true && Input.GetKeyDown(KeyCode.E))
        {
            SkipMessage.SetActive(false);

            SlimeMessage.SetActive(false);
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy"))
        {
            jump = 25f;

            autoJump = true;

            AutoJump();

            slimeBox = true;

            SlimeBoxMessage();
        }

        else
        {
            jump = 10f;
        }
    }

    void AutoJump()
    {
        if (autoJump == true)
        {
            velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        }
    }

    void SlimeBoxMessage()
    {
        if (slimeBox == true)
        {
            SlimeMessage.SetActive(true);

            SkipMessage.SetActive(true);
        }
    }

    void Hint1()
    {
        if (Hint2.activeSelf == true)
        {
            gameObject.SetActive(false);
        }
    }

    void Zeb11()
    {
        if (Zeb1.activeSelf == true)
        {
            Yeet1.SetActive(true);
        }
    }

    void Wack2()
    {
        if (Wack1.activeSelf == false)
        {
            Zeb1.SetActive(true);

            Debug.Log("Finished");
        }
    }

    void Hopper()
    {
        if (Hop.activeSelf == true)
        {
            Hop2.SetActive(true);

            YEETER.SetActive(false);

            Debug.Log("Gimma");
        }
    }
}
