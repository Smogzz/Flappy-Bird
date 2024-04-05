using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;
    float repaetWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repaetWidth = startPos.x - 14f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < repaetWidth)
        {
            transform.position = startPos;
        }
    }
}
