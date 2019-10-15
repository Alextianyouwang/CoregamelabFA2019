using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    Vector2 mosPos;
    public GameObject Square;
    public GameObject Triangle;

    public float speed;

    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

        speed = 10;

     
    }

    // Update is called once per frame
    void Update()
    {

        mosPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        Triangle.transform.position = new Vector2(mosPos.x, mosPos.y);

       // Debug.Log(mosPos);

        Vector2 difference = mosPos - (Vector2)Square.transform.position;

        float distance = difference.magnitude;

        //Debug.Log(distance);

        Vector2 direction = difference / distance;

        Square.GetComponent<Rigidbody2D>().velocity = direction * speed;

       

    }
}
