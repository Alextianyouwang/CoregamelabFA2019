using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RExplotionS : MonoBehaviour
{
    Animator explode;
    // Start is called before the first frame update
    void Start()
    {
        explode = GetComponent<Animator>();
        explode.speed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "P1")
        {
            P1HP.P1H -= 10;

        }

        if (collision.gameObject.tag == "P2")
        {
            P2HP.P2H -= 10;

        }
    }
}
