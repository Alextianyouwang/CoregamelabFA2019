using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1BombAction : MonoBehaviour
{
    public GameObject explosion;
   // public static Vector2 bombPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // bombPos = transform.position;

        if (Input.GetKeyUp(KeyCode.W))
        {
            GameObject e = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(e, 0.8f);
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.tag == "wall")
        {
            GameObject e = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(e, 0.8f);
            Destroy(this.gameObject);

        }*/

        if (collision.gameObject.tag == "P1" )
        {
            GameObject e = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(e, 0.8f);
            Destroy(this.gameObject);
            P1HP.P1H -= 100;
        }

        if (collision.gameObject.tag == "P2")
        {
            GameObject e = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(e, 0.8f);
            Destroy(this.gameObject);

            P2HP.P2H -= 100;
        }

        if (collision.gameObject.tag == "bound")
        {
            Destroy(gameObject);
        }
    }
}
