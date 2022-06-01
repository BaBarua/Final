using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPTWO : MonoBehaviour
{
    public float speed = 4.5f;
    void Start()
    {

    }



    void Update()
    {
        transform.position += -transform.right * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D ball)
    {

    }
}
