using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2RocketMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float RocketSpeed = 3;
    public Transform target;
    public GameObject Player2;

    float MaxHealth;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.position = Player2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.up * RocketSpeed;
        Vector2 direction = (Vector2)target.position - rb.position;
        float rotateAmount = Vector3.Cross(transform.up, direction).z;
        rb.angularVelocity = rotateAmount * 200;

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "P1Bullet")
        {
            MaxHealth -= 1;
            if (MaxHealth <= 0)
            {
                // GameObject.SetActive = false;
            }
        }
    }
}
