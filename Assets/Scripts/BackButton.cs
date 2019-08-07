using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{


    public ScreenFader Fader;
    public string LeveltoLoad = "Level Name";




    public void Back()
    {


        Fader.FadeTo(LeveltoLoad);
    }
}
