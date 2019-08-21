using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winningleveltoload : MonoBehaviour
{

    public ScreenFader fader;
    public string LeveltoLoad = "Winning Level";
    public int LevelToUnlock = 2;
    public GameObject ScoreBoi;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    if(collision.gameObject.tag == "Player")
        {

          ScoreBoi.GetComponent<Scores>().GetHighScore();

            PlayerPrefs.SetInt("levelReached", LevelToUnlock);

            fader.FadeTo(LeveltoLoad);

           
        }
    }

}
