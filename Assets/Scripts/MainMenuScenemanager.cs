using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScenemanager : MonoBehaviour
{
    public ScreenFader Fader;
    public string P_Play = "Name";
    public string L_LevelSelect = "Name";
    public string O_options = "Name";
    public string C_credits = "Name";





    // Load the scene accourding to button Pressed....
    public void Play()
    {


        Fader.FadeTo(P_Play);

    }


    public void LevelSelect()
    {


        Fader.FadeTo(L_LevelSelect);

    }


    public void Options()
    {

        Fader.FadeTo(O_options);


    }


    public void Credits()
    {

        Fader.FadeTo(C_credits);


    }

    public void Quit()
    {
        Application.Quit();
    }


}
