using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Bullet : MonoBehaviour
{

    Rigidbody2D rb;

    public GameObject BulletExp;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "P2")
        {
            P2HP.P2H -= 5;
            
        }

        if (collision.gameObject.tag == "bound")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "P2B")
        {
            GameObject e = Instantiate(BulletExp, transform.position, Quaternion.identity);
            Destroy(e, 0.5f);
            Destroy(this.gameObject);
        }
    }

  
}

