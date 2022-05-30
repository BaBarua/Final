using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            player.velocity = new Vector2(0f, 2f);
        } else if (Input.GetKey(KeyCode.S)) {
            player.velocity = new Vector2(0f, -2f);
        } else {
            player.velocity = new Vector2(0f, 0f);
        }
    }
}
