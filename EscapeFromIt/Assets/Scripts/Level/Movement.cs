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
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy"))
        {
            jump = 40f;

            autoJump = true;

            AutoJump();
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
}
