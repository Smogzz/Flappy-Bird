using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pipePrefab;
    float minY = -1.95f;
    float maxY = -1.06f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnPipes", 2.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(14.12f, Random.Range(minY,maxY)),Quaternion.identity);
    }
    

}

