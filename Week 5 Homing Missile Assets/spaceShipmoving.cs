using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipmoving : MonoBehaviour
{

    public GameObject tubeHodder;
    public GameObject bulletStart;
    public GameObject bullet;
    public GameObject missle;
    float bulletSpeed = -30;
    public float speed =7;
    public Vector2 movement;
    public Rigidbody2D rb;
    public GameObject explosion;
    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        Vector3 difference = transform.position - missle.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg - 45;
        tubeHodder.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        if (Input.GetKey(KeyCode.Space))
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            if (timer >= 0.15f) {
                fireBullet(direction, rotationZ);
             
                timer = 0;
            }
        }
    }

    private void FixedUpdate()
    {



        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void fireBullet(Vector2 direction,float rotationZ)
    {
        GameObject b = Instantiate(bullet) as GameObject;
        b.transform.position = bulletStart.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        Debug.Log("Fire");


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            GameObject E = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(E, 1);
            Destroy(gameObject);
        }
    }


}
