using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertwocontroller : MonoBehaviour
{
    private Rigidbody2D player;
    public bool canmove;
    public float cantmovetime = 2;
    public float canmovenow = 0;
    public bool Stimer;
    void Start()
    {
        player = this.GetComponent<Rigidbody2D>();
        canmove = true;
        
    }

    void Update()
    {

        movecontroller();

        Timmer();

        Debug.Log(canmovenow);

        //TimmerSet();


    }

    public void movecontroller()

    {
        if (canmove == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                player.velocity = new Vector2(0f, 5f);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                player.velocity = new Vector2(0f, -5f);
            }
            else
            {
                player.velocity = new Vector2(0f, 0f);
            }
        }
    }


    public void Timmer()
    {
        if (Stimer == true)
        {
            canmovenow = Time.time + cantmovetime;

            if (canmovenow >= 8)
            {
                canmove = true;

                Stimer = false;

                canmovenow = 0;
            }
        }
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Orb"))
        {

            canmove = false;

            Debug.Log(canmove);

            Stimer = true;

            Debug.Log(Stimer);
        }
    }

    public void TimmerSet()
    {
        if (canmovenow >= 2)
        {
            
            canmove = true;

            Debug.Log(canmove);

            canmovenow = 0f;

            Stimer = false;

        }
    }
}
