using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMOvement : MonoBehaviour
{

    public GameObject Concert; // Refrencing the object that player need to reach.
    public float Speed = 10f;
    public float JumpForce = 10f;

    bool IsGrounded; // For Checking if the player Grounded.




    public void Start()
    {
        // Making sure that player is grounded.
        IsGrounded = true;
    }

    // moving player towards the concert gameobject position.
    public void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, Concert.transform.position, Speed * Time.deltaTime);

        Jump();
    }

    // making player jump using J Key. 
    public void Jump ()
    {
        if(Input.GetKeyDown(KeyCode.J)&& IsGrounded)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce);
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
