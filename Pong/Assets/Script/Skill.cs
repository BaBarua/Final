using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public float speed = 4.5f;
    

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
            Destroy(gameObject);
        }
    }

}


