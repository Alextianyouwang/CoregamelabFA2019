using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missleMovement : MonoBehaviour
{
    public Transform target;
    public GameObject player;
    public GameObject explosion;
    

    private Rigidbody2D rb;

    public float speed = 5;

    public float rotateSpeed = 400f;


    
    // Start is called before the first frame update
    void Start()
    {
   
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthBar.health <= 0)
        {
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(e, 1);
            Destroy(this.gameObject);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed;

        Vector2 direction = (Vector2)target.position - rb.position;
        direction.Normalize();
       float rotateAmount = Vector3.Cross(transform.up, direction).z;
        rb.angularVelocity = rotateAmount * rotateSpeed;

    }
    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
           GameObject E = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(E, 1);
            Destroy(gameObject);
            Destroy(player);
            
        }

    }
}
