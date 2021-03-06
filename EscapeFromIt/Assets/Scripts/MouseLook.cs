using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSens = 150f;

    public Transform playerLook;

    float xRotate = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotate -= mouseY;

        xRotate = Mathf.Clamp(xRotate, -10f, 35f);

        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);

        playerLook.Rotate(Vector3.up * mouseX);
    }
}
