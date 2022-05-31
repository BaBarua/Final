using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Rigidbody2D player;
    public int cs;
    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<Rigidbody2D>();
        cs = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            player.velocity = new Vector2(0f, 5f);
        } else if (Input.GetKey(KeyCode.S)) {
            player.velocity = new Vector2(0f, -5f);
        } else {
            player.velocity = new Vector2(0f, 0f);
        }

        Debug.Log(cs);
    }
    private void OntriggerEnter2D(Collider2D ball)
    {
        if (ball.tag == "ball")
        {
            cs += 1;
        }

    }
}
