using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winningleveltoload : MonoBehaviour
{

    public ScreenFader fader;
    public string LeveltoLoad = "Winning Level";



    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    if(collision.gameObject.tag == "Player")
        {
            fader.FadeTo(LeveltoLoad);


        }
    }

}
