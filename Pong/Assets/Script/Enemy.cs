using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject traget;

    private float speed = 4.0f;
    
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > traget.transform.position.y)
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }

        if (transform.position.y < traget.transform.position.y)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }
    }


}
