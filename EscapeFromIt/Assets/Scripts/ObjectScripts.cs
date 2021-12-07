using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ObjectScripts : MonoBehaviour
{
    public static float newJump;

    public GameObject SlimeBox;

    public GameObject FirstHint;

    public static Rigidbody rb;

    public GameObject SecondHint;

    public GameObject Respawn;

    float lavaTime = 30f;

    public static int CountLava = 5;

    Text counting;

    public GameObject TestHint;

    public GameObject TestHint2;

    public GameObject TestHint3;

    public GameObject TestHint4;

    public GameObject ifSoDo;

    public GameObject SHEESH;

    public GameObject OYALE;

    public GameObject Gimma;

    public GameObject Koweid;

    public GameObject Zebs;

    public GameObject Koweid2;

    public GameObject Zebs2;

    public GameObject HintToHint;

    public GameObject HideHint;

    public GameObject Abc;

    public GameObject Def;

    public GameObject Ghi;

    public GameObject Jkl;

    public GameObject kank;

    public GameObject kenk;

    public GameObject kink;

    public GameObject konk;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        PlayerMovement.OnGround = true;

        counting = GetComponent<Text>();
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
            PlayerMovement.OnGround = true;
        }

        if (collision.gameObject.tag == "Hint1")
        {
            Debug.Log("Go");

            Debug.Log("To");

            Debug.Log("Hint2");

            PlayerMovement.OnGround = true;

            SecondHint.SetActive(true);
        }

        if (collision.gameObject.tag == "Respawn")
        {
            SecondHint.SetActive(false);

            Respawn.SetActive(true);

            Debug.Log("Test Respawn");

            Debug.Log("This is");

            Debug.Log("A");

            Debug.Log("Respawn");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && Respawn.activeSelf == true)
        {
            SceneManager.LoadScene("Main");
        }
    }

    void JumpingSlime()
    {
        rb.velocity = new Vector3(0, 150f, 0);
    }

    void LavaCountdown()
    {
        counting.text = "Lava will kill you in " + CountLava;
    }

    void TestHintYeet()
    {
        if (TestHint.activeSelf == true)
        {
            TestHint2.SetActive(true);
        }
    }

    void IfSoHint()
    {
        if (TestHint3.activeSelf == true)
        {
            TestHint4.SetActive(false);
        }
    }

    void DoSo()
    {
        if (ifSoDo.activeSelf == false)
        {
            gameObject.SetActive(true);

            Debug.Log("Finishedd");
        }

    }

    void Gimmaa()
    {
        if (Gimma.activeSelf == false)
        {
            gameObject.SetActive(true);

            Debug.Log("Zebbeee");
        }
    }

    void SHEESHSSS()

    {
        if (SHEESH.activeSelf == true)
        {
            gameObject.SetActive(false);

            Debug.Log("WHOESHOEM");
        }
    }

    void Kowid()
    {

        if (Koweid.activeSelf == true)
        {
            gameObject.SetActive(false);
        }

    }

    void Kowid2()
    {

        if (Koweid2.activeSelf == false)
        {
            gameObject.SetActive(true);
        }

    }

    void Zeb()

    {

        if (Zebs.activeSelf == false)

        {
            gameObject.SetActive(true);

            Debug.Log("Yeet");
        }

    }

    void Zeb2()
    {
        if (Zebs2.activeSelf == true)

        {
            gameObject.SetActive(false);

            Debug.Log("If");

            Debug.Log("So");

            Debug.Log("Do");
        }
    }

    void HideH()
    {

        if(HideHint.activeSelf == false)
        {
            gameObject.SetActive(true);

            Debug.Log("Correct");

        }
    }

    void Hintt()
    {

        if (HintToHint.activeSelf == true)
        {

            gameObject.SetActive(false);

            Debug.Log("Correct21");

            Debug.Log("Zemmel");


            Debug.Log("Yes");
        }
    }

    void Alfa()
    {

        if (Abc.activeSelf == false)

        {

            gameObject.SetActive(true);

        }

    }

    void Bet()

    {

        if (Def.activeSelf == true)

        {

            gameObject.SetActive(false);

            Debug.Log("Yessir");


            Debug.Log("Moad");

        }


        else

        {

            gameObject.SetActive(true);

            Debug.Log("Nosir");

            Debug.Log("Ozefo");

        }

    }

    void DeOverige()
    {

        if (Ghi.activeSelf == false)

        {

            gameObject.SetActive(true);

            Debug.Log(" ");

        }

        else
        {

            gameObject.SetActive(false);

            Debug.Log("Overige Active ");

        }

    }

    void JkkL()

    {

        if (Jkl.activeSelf == true)
        
        {

            gameObject.SetActive(false);

            Debug.Log(" T ");

        }

        else

        {

            gameObject.SetActive(true);

        }

    }


    void kankk()

    {

        if (kank.activeSelf == true)


        {

            gameObject.SetActive(false);

            Debug.Log("Kank");

        }

        else

        {

            gameObject.SetActive(true);

            Debug.Log("Kankk");

        }


    }

    void Kenkk()

    {

        if (kenk.activeSelf == false)

        {

            gameObject.SetActive(true);

            Debug.Log("Kenk");

        }

        else

        {

            gameObject.SetActive(false);

            Debug.Log("Kenkk");

        }

    }

    void Konkk()

    {

        if (konk.activeSelf == true)

        {

            gameObject.SetActive(false);

            Debug.Log("Konk");

        }


        else

        {

            gameObject.SetActive(true);

            Debug.Log("Konkk");

        }

    }

    void Kinkk()

    {

        if (kink.activeSelf == false)

        {

            gameObject.SetActive(true);


            Debug.Log("Kink");

        }

        else

        {

            gameObject.SetActive(false);

            Debug.Log("Kinkk");

        }

    }

}
