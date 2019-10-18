using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2UltimateSpawn : MonoBehaviour
{
    public GameObject P2UltS;
    float number;
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
            if (P2HP.P2H <= 40)
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
        Instantiate(P2UltS, transform.position, Quaternion.identity);
        number++;
    }
}
