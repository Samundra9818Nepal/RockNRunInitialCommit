using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDelay : MonoBehaviour
{
    AudioSource MyAudio;

    // Playing the Audio after 3 seconds.
    private void Start()
    {

        // Refrencing Myaudio with gameobject audioSource.
       MyAudio= GetComponent<AudioSource>();


        // Play audio after 3 seconds.
      //  MyAudio.PlayDelayed(3.0f);




    }



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            MyAudio.Play();

        }

    }
}
