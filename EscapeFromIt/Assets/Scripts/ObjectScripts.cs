using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScripts : MonoBehaviour
{
    public GameObject SlimeBox;

    void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "Player")
        {
            SlimeBox.SetActive(false);
        }
    }
}
