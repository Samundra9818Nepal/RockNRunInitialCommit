using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMOvement : MonoBehaviour
{

    public GameObject ParticalPref; // Particle system.
   // public GameObject Badsound;//Badsound...
   // AudioSource VolumeDown; // for making the badsound volume up.
    //public GameObject CoinPickUpsound;
    public float Speed;
    public float JumpForce;
    //public GameObject Screenflash;
    Animator anim;
    CapsuleCollider2D Refcol;

    bool IsGrounded; // For Checking if the player Grounded.


    Rigidbody2D RB;


    public void Start()
    {
        // Making sure that player is grounded.
        IsGrounded = true;
        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Refcol = GetComponent<CapsuleCollider2D>();
        //VolumeDown = GetComponent<AudioSource>();
        
    }

    //Moving player towards the concert gameobject position.
    public void FixedUpdate()
    {
        RB.velocity = new Vector2(Speed, RB.velocity.y);
        //transform.position = Vector2.MoveTowards(transform.position, Concert.transform.position, Speed * Time.deltaTime);
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

            anim.SetBool("PlayerSliding", true);
            Refcol.size = new Vector2(Refcol.size.x, 7f);
        
            
        } else if(Input.GetKeyUp("c"))
        {


            anim.SetBool("PlayerSliding", false);

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


        // Player Trip over functions.
        if (collision.gameObject.tag == "obstacles")
        {

            //VolumeDown.volume = 0f;
            anim.SetBool("Player Tripover", true);
            Debug.Log("Player Tripover");
            //Screenflash.SetActive(true);
           //GameObject Bad_sound = Instantiate(Badsound, transform.position, transform.rotation);
           //Destroy(Bad_sound, 3f);
            
        }

    }


    // Destroying the collectables..

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Collectables")
        {
            //GameObject PickupSound = Instantiate(CoinPickUpsound, transform.position, transform.rotation);
            //Destroy(PickupSound, 3f);
            GameObject Particles = Instantiate(ParticalPref, this.transform.position, this.transform.rotation);
            Destroy(collision.gameObject);
            Destroy(Particles, 2f);

        }

    }
    // Disbaling the PlayerTrip over animation.

    private void OnCollisionExit2D(Collision2D collision)
    {
        anim.SetBool("Player Tripover", false);
        Debug.Log("Player Tripover");
       // Screenflash.SetActive(false);
        //VolumeDown.volume = 1f;
    }

}
