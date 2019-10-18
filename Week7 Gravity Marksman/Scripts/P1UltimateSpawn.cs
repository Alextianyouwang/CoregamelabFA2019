using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1UltimateSpawn : MonoBehaviour
{
    public GameObject P1UltS;
    float number = 0;

    bool canInst;
    // Start is called before the first frame update
    void Start()
    {
        canInst = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canInst)
        {
            if (P1HP.P1H <= 40)
            {
                inst();
            }

        }
        if (number >= 1)
        {
            canInst = false;
        }
       
    }

    void inst()
    {
        Instantiate(P1UltS, transform.position, Quaternion.identity);
        number++;
    }
}
