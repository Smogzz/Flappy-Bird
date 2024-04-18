using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    RedBird birdScript;
    // Start is called before the first frame update
    void Awake()
    {
       birdScript = GameObject.Find("RedBird").GetComponent<RedBird>(); 
    }

    // Update is called once per frame
    void Update()
    {

       if(birdScript.isAlive == true) 
       {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
       }
    }
}
