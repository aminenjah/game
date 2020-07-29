using System.Numerics;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class myfirstscript : MonoBehaviour
{
    int x = 5;
    int y = 3;
    float r = 1.2f;
    string userName = "ada";
    bool win = false; 
    vector2 position;
    public Text myText;
   
    // start is called before the first frame update 
     void Start()
    {
        Debug.Log("hello world!");
        Debug.Log(x);

        x = x + 1;
        Debug.Log(x);

        int z = y - x;
        Debug.Log(z);

        Debug.Log(r);

        Debug.Log("ada");

        Debug.Log(1 < 2);
        Debug.Log(2 < 1);
        win = true;
        Debug.Log("you win ");
        
        
        

        
    }

      
    void Update()
    {
        Debug.Log("hello!"); 
    }

}