using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPos : MonoBehaviour
{

    public static Vector2 bombPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bombPos = transform.position;
    }
}
