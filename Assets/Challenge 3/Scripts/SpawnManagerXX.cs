﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerXX : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 1;
    private float spawnInterval = 1.5f;

    private PlayerControllerXX playerControllerScript;

    
     
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerXX>();
    }

    // Spawn obstacles
    void SpawnObjects ()
    {
        // Set random spawn location and random object index
       Vector3 spawnLocation = new Vector3(30, Random.Range(5, 15), 0);
        int index = Random.Range(0, objectPrefabs.Length);

        // If game is still active, spawn new object
        if (playerControllerScript.gameOver == false )
        {
            Instantiate(objectPrefabs[index], spawnLocation, transform.rotation);
        }

    }
}
