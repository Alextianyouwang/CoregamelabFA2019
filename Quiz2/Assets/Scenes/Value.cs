using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value : MonoBehaviour
{
    public static Value Alex;
    public float Speed;
    private void Awake()
    {
        if (Alex == null)
        {
            Alex = this;
            DontDestroyOnLoad(this);
        }
        else if (Alex != this)

        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Speed = ChangeLevel.newLevel;
    }
}
