using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgression : MonoBehaviour
{
    public GameObject[] Upgrades;

    void Start()
    {
        int rand = Random.Range(0, Upgrades.Length);
        Instantiate(Upgrades[rand], transform.position, Quaternion.identity);

    }
}
