using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public float speed = 4.5f;
    public GameObject traget;

    void Start()
    { }
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playertwocontroller movescript = GetComponent<playertwocontroller>();


            movescript.canmove = false;



            movescript.canmove = true;
        }
    }
}


