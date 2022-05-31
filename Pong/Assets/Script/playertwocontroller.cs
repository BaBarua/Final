using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertwocontroller : MonoBehaviour
{
    private Rigidbody2D player;
    void Start()
    {
        player = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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
