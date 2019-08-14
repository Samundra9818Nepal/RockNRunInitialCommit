using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.IO;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    public ScreenFader Fader;
    public string Level_1 = "String Name";
    public string Level_2 = "String Name";
    public string Level_3 = "String Name";
    public string Level_4 = "String Name";
    public string ResetScore = "0";
    public GameObject scoreboi;


    public Button[] levelButtons;



    void Start()

    {


        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {

            if (i + 1 > levelReached)

                levelButtons[i].interactable = false;
        }
    }

    public void Select(string levelName)

    {
        Fader.FadeTo(levelName);


    }

    // Loading the level in respect to the buttons clicked.




    public void Level1()
    {

        Fader.FadeTo(Level_1);

    }


    public void Level2()
    {


        Fader.FadeTo(Level_2);

    }


    public void Level3()
    {


        Fader.FadeTo(Level_3);

    }

    public void Level4()
    {


        Fader.FadeTo(Level_4);

    }


    // Reset the Levels.

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        scoreboi.GetComponent<Scores>().Reset();



    }

}
