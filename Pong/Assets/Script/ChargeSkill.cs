using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeSkill : MonoBehaviour
{

    public int cs;
    void Start()
    {
        cs = 0;
    }

    
    void Update()
    {
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

