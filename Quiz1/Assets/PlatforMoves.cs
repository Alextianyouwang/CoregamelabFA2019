using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatforMoves : MonoBehaviour
{
    // I tried to use a different mathord to sove the rotation, but i failed.
    public GameObject platform;
    float rotationZ;
    Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        
        //transform.Rotate(new Vector3(0, 0, Input.mousePosition.x));
        inst();
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
       // float x = Input.mousePosition.x;
       // transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        Vector3 difference = target - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x)*5 ;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
    }

    void inst()

    {
        //float x = Input.mousePosition.x;
        GameObject p = Instantiate(platform) as GameObject;
        p.transform.position = new Vector2(0, 0);
        p.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        //transform.Rotate(new Vector3(0,0,x));

        //Instantiate(platform, transform.position, transform.rotation);

    }
}
