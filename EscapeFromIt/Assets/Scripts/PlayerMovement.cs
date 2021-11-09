using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;

    public float speed = 12f;

    Vector3 velocity;

    public static Rigidbody rb;

    bool OnGround;

    Vector3 fallSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        OnGround = true;

        velocity.y -= 450;
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
        if (OnGround == false)
        {
            Physics.gravity = fallSpeed;
            fallSpeed.y = -450;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnGround = false;

            rb.AddForce(0, 50, 0, ForceMode.Impulse);
        }
    }
}
