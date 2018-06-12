using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteriods
{
    public class AsteriodSpawner: MonoBehaviour
    {
        public GameObject[] asteriodPrefabs; // Array of prefabs to spawn
        public float spawnRate = 1f; // Rate of spawn 
        public float spawnRadius = 5f; // Radius of spawn 
       
        void Spawn ()
        {
            // Randomize a position 
            Vector3 rand = Random.insideUnitSphere * spawnRadius;
            // Cancel the z axis on position 
            rand.z = 0f;
            // Generate position using rand 
            Vector3 position = transform.position + rand;
            // Generate random index into prefab array 
            int randIndex = Random.Range(0, asteriodPrefabs.Length);
            // Get random asteriod 
            GameObject randAsteriod = asteriodPrefabs[randIndex];
            // Clone random asteriod 
            GameObject clone = Instantiate(randAsteriod);
            // Set clon's position
            clone.transform.position = position;
        }
             
        // Use this for initialization
        void Start()
        {
            // Calls a function a specified amount of times 
            InvokeRepeating("Spawn", 0, spawnRate);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

