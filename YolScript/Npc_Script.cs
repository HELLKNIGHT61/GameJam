using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Npc_Script : MonoBehaviour
{
    

    Rigidbody2D rb2d;
    SpriteRenderer sprite;

    [SerializeField] GameObject panel;
    public int sprite_degeri;
    int gidilen_serit;

    float varsayilan_hiz;

    public Sprite car1, car2, car3, car4, car5, car6, car7, car8, car9, car10,
           car11, car12, car13, car14, car15, car16, car17, car18;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = rb2d.GetComponent<SpriteRenderer>();

        sprite_degeri = Random.Range(1, 19);
        gidilen_serit = Random.Range(1, 5);
        varsayilan_hiz = Random.Range(2.5f, 3.5f);

        if (gidilen_serit == 1)
        {
            transform.position = new Vector3(-1.44f, transform.position.y + 7, 0);
        }

        else if (gidilen_serit == 2)
        {
            transform.position = new Vector3(-0.5f, transform.position.y + 7, 0);
        }

        else if (gidilen_serit == 3)
        {
            transform.position = new Vector3(0.51f, transform.position.y + 7, 0);
        }

        if (gidilen_serit == 4)
        {
            transform.position = new Vector3(1.46f, transform.position.y + 7, 0);
        }

        switch (sprite_degeri)
        {
            case 1:
                sprite.sprite = car1;
                break;
            case 2:
                sprite.sprite = car2;
                break;
            case 3:
                sprite.sprite = car3;
                break;
            case 4:
                sprite.sprite = car4;
                break;
            case 5:
                sprite.sprite = car5;
                break;
            case 6:
                sprite.sprite = car6;
                break;
            case 7:
                sprite.sprite = car7;
                break;
            case 8:
                sprite.sprite = car8;
                break;
            case 9:
                sprite.sprite = car9;
                break;
            case 10:
                sprite.sprite = car10;
                break;
            case 11:
                sprite.sprite = car11;
                break;
            case 12:
                sprite.sprite = car12;
                break;
            case 13:
                sprite.sprite = car13;
                break;
            case 14:
                sprite.sprite = car14;
                break;
            case 15:
                sprite.sprite = car15;
                break;
            case 16:
                sprite.sprite = car16;
                break;
            case 17:
                sprite.sprite = car17;
                break;
            case 18:
                sprite.sprite = car18;
                break;
        }
    }


    void Update()
    {
        rb2d.velocity = new Vector3(transform.position.x, varsayilan_hiz * 50 * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("mainCar"))
        {
            SceneManager.LoadScene(3);
        }
    }


}
