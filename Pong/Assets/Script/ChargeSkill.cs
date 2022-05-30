using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            cs++;
        }
    }
}

