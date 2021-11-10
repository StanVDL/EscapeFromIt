using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;

    public float speed = 12f;

    Vector3 velocity;

    public static Rigidbody rb;

    public static bool OnGround;

    Vector3 fallSpeed;

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

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnGround == true)
        {
            Jumping();
            OnGround = false;

            Physics.gravity = new Vector3(0, -450F, 0);
        }
    }

    void Jumping()
    {
            rb.velocity = new Vector3(0, 150f, 0);
    }
}
