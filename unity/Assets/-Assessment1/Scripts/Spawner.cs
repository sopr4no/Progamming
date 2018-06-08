﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs = null;
    public float spawnRadius = 5.0f;
    public float spawnRate = 1.0f;
    private float spawnFactor = 0.0f;


    // Update is called once per frame
    void Update()
    {
        HandleSpawn();
    }

    void HandleSpawn()
    // Handling spawning of chips and speed 
    {
        spawnFactor = Time.deltaTime;
        if (spawnFactor > spawnRate)
        {
            int randomIndex = Random.Range(0, prefabs.Length);
            Spawn(prefabs[randomIndex]);
            spawnFactor = 0;
        }
    }

    void Spawn(GameObject _object)
    // Spawning of chips randomly according to point 
    {
        GameObject newObject = Instantiate(_object);
        Vector3 randomPoint = Random.insideUnitCircle * spawnRadius;
        newObject.transform.position = transform.position + randomPoint;
    }
}

