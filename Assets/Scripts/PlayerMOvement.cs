using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMOvement : MonoBehaviour
{


    public float Speed;
    public float JumpForce;
    Animator Slide;
    CapsuleCollider2D Refcol;

    bool IsGrounded; // For Checking if the player Grounded.


    Rigidbody2D RB;


    public void Start()
    {

      
        // Making sure that player is grounded.
        IsGrounded = true;
        RB = GetComponent<Rigidbody2D>();
        Slide = GetComponent<Animator>();
        Refcol = GetComponent<CapsuleCollider2D>();
    }

    // moving player towards the concert gameobject position.
    public void FixedUpdate()
    {

        RB.velocity = new Vector2(Speed, RB.velocity.y);
      //  transform.position = Vector2.MoveTowards(transform.position, Concert.transform.position, Speed * Time.deltaTime);

    
    }

  

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {

            RB.velocity = new Vector2(RB.velocity.x, JumpForce);

            // this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce);
            IsGrounded = false;
        }



        // this function is for sliding the player by pressing C.
        if(Input.GetKeyDown("c"))
        {


            Slide.SetBool("PlayerSliding", true);
            Refcol.size = new Vector2(Refcol.size.x, 7f);
        
            
        } else if(Input.GetKeyUp("c"))
        {


            Slide.SetBool("PlayerSliding", false);

            //Slide.SetBool("PlayerReturn", true);


            Refcol.size = new Vector2(Refcol.size.x, 10f);
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
