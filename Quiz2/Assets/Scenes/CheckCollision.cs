using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CheckCollision : MonoBehaviour
{
    public Text timeLeft;
    public float timer = 3;
    bool isHit = false;
    
    // Start is called before the first frame update
    void Start()
    {
        showText(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {
            timer -= Time.deltaTime;

        }
        timeLeft.text = timer.ToString();

        if (timer <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "sq")
        {
            Debug.Log("Hit");
            showText(true);
            timer = 3;
            isHit = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "sq")
        {
            Debug.Log("left");
            showText(true);
            timer = 3;
            isHit = false;
            showText(false);
        }
    }

    void showText( bool isShowing)
    {
        timeLeft.gameObject.SetActive(isShowing);
    }
}
