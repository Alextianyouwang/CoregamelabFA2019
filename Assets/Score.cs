using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Rigidbody2D rb;
    public int score;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        AddScore();
    }
   
    void AddScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }
    
}
