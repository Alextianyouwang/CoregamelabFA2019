using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sqmovement : MonoBehaviour
{

    Rigidbody2D rb;
    public float forceamount;


    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(3, 3);
        rb = GetComponent<Rigidbody2D>();
        forceamount = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))

        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("Clicked!" + worldPoint.x + "" + worldPoint.y);

            Vector3 direction = worldPoint - transform.position;
            rb.AddForce(new Vector2(direction.x, direction.y)*forceamount, ForceMode2D.Impulse);

        }
    }
}
