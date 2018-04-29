using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {
    public Transform[] spawnpoints;
    public GameObject cubePrefab;
    private float timeToDrum = 2f;
    public float timeBetweenSpawns = 1f;
    int drum;

    // Use this for initialization
    void Start()
    {
        // Instantiate(cubePrefab, spawnpoints[0]);
        //Instantiate(cubePrefab, spawnpoints[1]);
        drum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToDrum)
        {
            timeToDrum = Time.time + timeBetweenSpawns;
            if (drum == 0)
            {
                Instantiate(cubePrefab, spawnpoints[1].position, Quaternion.identity);
                drum++;
            }
            else
            {
                Instantiate(cubePrefab, spawnpoints[0].position, Quaternion.identity);
                drum--;
            }
        }

    }

}


