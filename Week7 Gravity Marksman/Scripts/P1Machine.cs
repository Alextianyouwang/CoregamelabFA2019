using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Machine : MonoBehaviour
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
        if (collision.gameObject.tag == "P2")
        {
            P2HP.P2H -= 4;
            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "bound")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "bound" || collision.gameObject.tag == "wall" )
        {
            
          
            Destroy(gameObject);
        }
    }
}
