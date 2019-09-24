using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulling2 : MonoBehaviour
{

    Rigidbody2D rb;
    Vector3 direction;
    Vector3 planetpos;
    public float forceamount;
    public GameObject Center;


    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(2, 2);
        transform.position = new Vector2(5,5);
        rb = GetComponent<Rigidbody2D>();

        //planetpos = Center.transform.position;
        forceamount = 5;
        rb.AddForce(Vector2.left * 10, ForceMode2D.Impulse);
    }

    // Update is called once per frame
   private void Update()
    {
        planetpos = Center.transform.position;
        direction = planetpos - transform.position;
        rb.AddForce(direction * forceamount);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(Random.value, Random.value, Random.value, 1.0f);
    }
}
