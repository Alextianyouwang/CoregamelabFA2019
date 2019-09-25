using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repel : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;
    float spinForce;
    public GameObject Climber;
    Vector2 directionUpdate;
    public float forceamount;





    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(Random.Range(10.0f, -10.0f), Random.Range(10.0f, -10.0f));
        //spinForce = Random.Range(-50.0f, 50.0f);
        rb.AddForce(direction, ForceMode2D. Impulse);
        //rb.AddTourque(spinForce);
        forceamount = -0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        directionUpdate = Climber.transform.position - transform.position;
        rb.AddForce(direction * forceamount);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        collision.gameObject.GetComponent<SpriteRenderer>().color = Random.ColorHSV(1.0f, 0.0f, 1.0f, 1.0f, 1.0f, 0.0f);
    }
}

