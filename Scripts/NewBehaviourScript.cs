using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // this is the spped of the racket movement 
    public float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        float y = Input.GetAxisRaw("Vertical2") * 10;
        new Vector2(0, y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public string axis;
    private void FixedUpdate()
    {
      //  this is  our GetAxixRaw input
        float y = Input.GetAxisRaw(axis) * 10;
      // just calling the Rigidbody2D to component to change its Velocity value
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, y);
        float v = Input.GetAxisRaw(axis) * speed;
    }
}
