﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour {

    public Transform[] coinSpawns;
    public GameObject Coin;

    // Use this for initialization
    void Start()
    {
        Spawn();
    }

    void Spawn() 
    {
        for (int i = 0; i < coinSpawns.Length; i++)
        {
            int coinFlip = Random.Range(0, 2);
            if (coinFlip > 0)
                Instantiate(Coin, coinSpawns[i].position, Quaternion.identity);
        }
    }
}
