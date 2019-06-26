using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggermusic : MonoBehaviour
{
    AudioSource MyAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        //play music
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("poo");
            MyAudio = GetComponent<AudioSource>();
            MyAudio.Play();
        }
     
    }
}
