using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrapping : MonoBehaviour
{

    float X;
    float Y;
    // Start is called before the first frame update
    void Start()
    {
        X = 15f;
        Y = 15f;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= X)
        {
            transform.position = new Vector2(-X, transform.position.y);

        }
        else if (transform.position.x <= -X)
        {
            transform.position = new Vector2(X, transform.position.y);

        }
        if (transform.position.y >= Y)
        {
            transform.position = new Vector2(transform.position.x,-Y);

        }
        else if (transform.position.y <= -Y)
        {
            transform.position = new Vector2(transform.position.x, Y);

        }
    }
}
