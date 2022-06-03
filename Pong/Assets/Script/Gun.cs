using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject sk;
    public Transform fireoff;
    public float cs;
    void Start()
    {
        cs = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.C))
        {
            if(cs >= 10 )
            {
                Instantiate(sk, fireoff.position, transform.rotation);

                cs -= 10;
            }
            
        }
        else if (Input.GetKey(KeyCode.A))
        {
            cs = cs + 0.001f;
        }
    }
}
