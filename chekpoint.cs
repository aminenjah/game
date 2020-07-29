using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chekpoint : MonoBehaviour { 
    int a = 2;
    int b = 3;
    int c;
   void sum()
    {
        c = a + b;
        Debug.Log(c);   
    }
    void prod()
    {
        c = a * b;
        Debug.Log(c);
    }
    void div()
    {
        c = a / b;
        Debug.Log(c);
    }
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
