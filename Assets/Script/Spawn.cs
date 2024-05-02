using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pipePrefab;
    float minY = -1.95f;
    float maxY = -1.06f;
    RedBird birdScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 2.0f, 2.0f);
        birdScript = GameObject.Find("RedBird").GetComponent<RedBird>();
    }

    // Update is called once per frame
    void Update()
    {
       if(birdScript.isAlive == false) 
       {
            CancelInvoke();
       }
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(14.12f, Random.Range(minY,maxY)),Quaternion.identity);
    }
    

}

