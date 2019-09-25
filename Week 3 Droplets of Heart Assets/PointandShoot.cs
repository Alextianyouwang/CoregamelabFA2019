using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointandShoot : MonoBehaviour
{
    public GameObject crossHair;
    private Vector3 target;

    public GameObject turret;
    public GameObject BulletPrefab;

    public float BulletSpeed = 60.0f;
    public GameObject bulletStart;

    float Drag;
    public Text ShowingDrag;

    public GameObject Indicator;

 

    
   

    // Start is called before the first frame update
    void Start()
    {
     
        Cursor.visible = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        Drag = BulletPrefab.GetComponent<Rigidbody2D>().drag;
        ShowingDrag.text =(40-Drag).ToString();
        Indicator.transform.localScale = new Vector2((50 - Drag) / 5,0.2f );
        Indicator.transform.position = new Vector2(0, -4.8f);

        Scoll();

        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        Cursor.visible = false;
        crossHair.transform.position = new Vector2(target.x, target.y);

        Vector3 difference = target - turret.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x)* Mathf.Rad2Deg;
        turret.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);
        }
       
    }

    void fireBullet(Vector2 direction, float rotationZ)
    {
        GameObject b = Instantiate(BulletPrefab) as GameObject;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.transform.position = bulletStart.transform.position;
        b.GetComponent<Rigidbody2D>().velocity = direction * BulletSpeed;
        Debug.Log("Fire!!!");
      
    }

    void Scoll()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            BulletPrefab.GetComponent<Rigidbody2D>().drag++;
            Debug.Log("Increase Drag!");
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            BulletPrefab.GetComponent<Rigidbody2D>().drag--;
            Debug.Log("Decrease Drag!");
        }

    }
    
    
}
