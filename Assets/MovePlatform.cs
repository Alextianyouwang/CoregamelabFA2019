using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlatform : MonoBehaviour
{
    public int score;
    public Text ScoreText;


    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Platform, transform.position, transform.rotation);
        //transform.position = new Vector2(0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.mousePosition.x;
        transform.position = new Vector2(0, 0);
        transform.rotation = Quaternion.Euler(0,0,(x-300)/10);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }

       




    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        AddScore();
      
      
    }

    void AddScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }

}
