using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{

    public SkillPTWO sk;
    public Transform fireoff;
    public float cs;
    void Start()
    {
        cs = 0;
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(cs);

        if (Input.GetKey(KeyCode.RightShift))
        {
            if(cs >= 10 )
            {
                Instantiate(sk, fireoff.position, transform.rotation);

                cs -= 10;
            }
            
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            cs = cs + 0.001f;
        }
    }
}
