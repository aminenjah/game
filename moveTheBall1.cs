// this is the ball script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTheBall1 : MonoBehaviour
{
    public float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        // initial Velocity 
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
