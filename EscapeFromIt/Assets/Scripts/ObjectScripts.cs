using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScripts : MonoBehaviour
{
    public static float newJump;

    public GameObject SlimeBox;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            bool v = PlayerMovement.jumpHeight == newJump;
        }

        if (collision.gameObject.tag == "Friendly")
        {
            PlayerMovement.isGrounded = true;

            if (PlayerMovement.isGrounded == true && Input.GetButtonDown("Jump"))
            {
                PlayerMovement.rb.AddForce(0, PlayerMovement.jumpHeight, 0);
            }

        }
    }
}
