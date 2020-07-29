using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI; // We have to add the UnityEngin.UI name space in order to work with Text variables
public class gravityscript : MonoBehaviour
{
    public Text scorerightText;
    public Text scoreleftText;
    int scoreRight;
    int scoreLeft;
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)

    {
        //asci art:
        //|| 1 <- at the top of the racket 
        //||
        //|| 0 <- at the middle of the racket
        //||
        //|| -1 <-at the bottom of the racket 
        return (ballPos.y - racketPos.y) / racketHeight;
    }
    float gravity = 0f;
    Vector2 speed;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 speed = new Vector2(1, 1);
        GetComponent<Rigidbody2D>().velocity = speed * 10;



    }

    // Update is called once per frame
    void Update()
    {
        gravity = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().gravityScale = gravity;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Wallright")
        {
            // this line will just add 1 point to the score
            scoreLeft++;
            // this line will convert the int score variable to a string variable 
            scoreleftText.text = scoreLeft.ToString();
        }
        if (col.gameObject.name == "Wallleft")
        {
            scoreRight++;
            scorerightText.text = scoreRight.ToString();
        }

        // Note:'col' holds the collision informations. if the 
        // Ball collided with a racket.then :
        // col.gameObject is the racket 
        // col.trasform.position is the racket's position
        // col.collider is the racket's collider 

        // hit left racket 
        if (col.gameObject.name == "RacketLeft")
        {
            // Calculate hitFactor
            float y = hitFactor(transform.position,
                col.transform.position,
                col.collider.bounds.size.y);
            // Calculate direction, make length=1 via normalized
            Vector2 dir = new Vector2(1, y).normalized;
            // set velocity with dir * speed;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        // Hit the right Racket?
        if (col.gameObject.name == "RacketRight")
        {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                    col.transform.position,
                    col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
         
    }
}
