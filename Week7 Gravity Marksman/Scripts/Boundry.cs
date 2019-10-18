using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Boundry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "P1")
        {

            P1HP.P1H = 100;
            P2HP.P2H = 100;
        
            SceneManager.LoadScene(2);

           
        }

        if (collision.gameObject.tag == "P2")
        {
            P1HP.P1H = 100;
            P2HP.P2H = 100;
         
            SceneManager.LoadScene(1);

          
        }
    }

    


}
