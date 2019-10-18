using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Rocket : MonoBehaviour
{
    Rigidbody2D rb;

    public GameObject explosion;
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
            float pureX = Mathf.Abs(rb.velocity.x);
            float pureY = Mathf.Abs(rb.velocity.y);
            float dmg = Mathf.Sqrt(pureX * pureX + pureY * pureY);

            P2HP.P2H -= dmg*2f;

            Destroy(this.gameObject);
            GameObject e = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(e, 0.8f);


            Debug.Log (dmg);
        }

        if (collision.gameObject.tag == "wall")
        {
            GameObject e = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(e, 0.8f);

            Destroy(this.gameObject);

        }

        if (collision.gameObject.tag == "bound")
        {
            Destroy(gameObject);
        }
    }
}
