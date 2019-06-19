using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMOvement : MonoBehaviour
{

    public GameObject Concert; // Refrencing the object that player need to reach.
    public float Speed = 10f;
    public float JumpForce = 10f;

    bool IsGrounded; // For Checking if the player Grounded.


    Rigidbody2D RB;


    public void Start()
    {

      
        // Making sure that player is grounded.
        IsGrounded = true;
        RB = GetComponent<Rigidbody2D>();
    }

    // moving player towards the concert gameobject position.
    public void FixedUpdate()
    {

        RB.velocity = new Vector2(Speed, RB.velocity.y);
      //  transform.position = Vector2.MoveTowards(transform.position, Concert.transform.position, Speed * Time.deltaTime);

    
    }

    // making player jump using J Key. 


    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {

            RB.velocity = new Vector2(RB.velocity.x, JumpForce);

            // this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce);
            IsGrounded = false;
        }

    }
   

    // Cheking that player has collide with the ground or not.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Ground"&& IsGrounded == false)
        {
            IsGrounded = true;
            Debug.Log("IsGrounded");
        }

    }


}
