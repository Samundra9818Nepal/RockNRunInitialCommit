using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Animator Playertrip;


    void Start()
    {

        Playertrip = GetComponent<Animator>();
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {



        // play animation to make player trip

        if (collision.gameObject.tag == "Enemy")
        {

            Playertrip.SetBool("Trip", true);



        }


    }

    // Stops animation after player extit the trigger box
.
    public void OnTriggerExit2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Enemy")
        {

            Playertrip.SetBool("Trip", false);



        }


    }
}
