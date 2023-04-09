using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Ellen_Control : MonoBehaviour
{
    Scene scene;
    Rigidbody2D rb;
    Animator ani;
    public int jumpSpeed;
    public bool ground = true;
    public int moveSpeed;
    float x;
    public AudioSource jumpsound;
    public AudioSource gameover;
    public GameObject panel;
    public AudioSource zafer;




    void Start()
    {


        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        //jumpsound = GetComponent<AudioSource>();
        //gameover = GetComponent<AudioSource>();
        //zafer = GetComponent<AudioSource>();
        scene = SceneManager.GetActiveScene();
    }



    void Update()
    {
        Hareket();
        Run();

        if (Input.GetKeyDown(KeyCode.Space) && ground)
        {
            Jump();
        }
    }

    void Jump()
    {


        rb.AddForce(Vector2.up * jumpSpeed);
        ground = false;
        ani.SetBool("jump", true);
        jumpsound.Play();

    }

    void Run()
    {
        if (Input.GetAxis("Horizontal") != 0 && Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 6;
            ani.SetBool("run", true);

        }
        else
        {
            moveSpeed = 3;
            ani.SetBool("run", false);
        }
    }



    void Hareket()
    {
        x = Input.GetAxis("Horizontal");
        Vector2 hareket = new Vector2(x * moveSpeed, rb.velocity.y);

        rb.velocity = hareket;

        if (x < 0)
        {
            transform.localScale = new Vector2(-1, 1);
            ani.SetFloat("speed", Mathf.Abs(x));




        }
        if (x > 0)
        {
            transform.localScale = new Vector2(1, 1);
            ani.SetFloat("speed", x);


        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zemin")
        {
            ground = true;
            ani.SetBool("jump", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Water"))
        {
            Death();
        }

        if (collision.gameObject.CompareTag("Kitap"))
        {
            GameObject.Find("Kitap").SetActive(false);
            zafer.Play();
            Invoke("Later", 3f);
        }
    }


    void Death()
    {
        rb.simulated = false;
        this.GetComponent<Collider2D>().enabled = false;
        ani.SetTrigger("death");
        gameover.Play();
        this.enabled = false;
        Invoke("Five", 3f);
        


    }

    void Five()
    {
        panel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    
    void Later()
    {
        SceneManager.LoadScene("Alperen Zafer Sahnesi");
    }
    


}