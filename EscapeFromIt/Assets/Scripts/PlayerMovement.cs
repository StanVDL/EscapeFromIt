using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;

    public float speed = 12f;
    public float gravity = -9.8f;
    public float jumpHeight = 10f;
    public float jumpSpeed = 5f;
    public Vector3 Jump;

    Vector3 velocity;

    public static Rigidbody rb;

    bool OnGround;

    public bool useGravity = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        OnGround = true;
}

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        rb.velocity = (transform.forward * z + transform.right * x) * speed;
    }

    void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnGround = false;

            GetComponent<Rigidbody>().AddRelativeForce(0, 10, 0);
        }

        if (OnGround == false)
        {

        }
    }

    void FixedUpdate()
    {
        rb.useGravity = false;
        if (useGravity) rb.AddForce(Physics.gravity * (rb.mass * rb.mass));
    }
}
