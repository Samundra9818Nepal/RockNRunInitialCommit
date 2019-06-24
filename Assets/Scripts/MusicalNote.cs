using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicalNote : MonoBehaviour
{
    public GameObject pickupEffect;
    public AudioClip pickupSound;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //play music
            //spawn particle system
            //add score
            Destroy(this.gameObject);
        }
    }
}
