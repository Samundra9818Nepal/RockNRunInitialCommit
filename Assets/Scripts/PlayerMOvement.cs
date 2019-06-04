using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMOvement : MonoBehaviour
{

    public GameObject Concert; // Refrencing the object that player need to reach.
    public float Speed = 10f;
    public float JumpForce = 10f;




    // moving player towards the concert gameobject position.
    public void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, Concert.transform.position, Speed * Time.deltaTime);

        Jump();
    }

    public void Jump ()

    {



        if(Input.GetKeyDown(KeyCode.J))
        {

            this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce);
        }
    }


}
