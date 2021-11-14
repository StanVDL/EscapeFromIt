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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float xx = Input.GetAxis("Horizontal");

        float zz = Input.GetAxis("Vertical");

        Vector3 move = transform.right * xx + transform.forward * zz;

        control.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        control.Move(velocity * Time.deltaTime);
    }
}
