using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Machine : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "P1")
        {
            P1HP.P1H -= 4;
            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "bound")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "bound" || collision.gameObject.tag == "wall" || collision.gameObject.tag == "P2")
        {
          
            Destroy(gameObject);
        }
    }
}
