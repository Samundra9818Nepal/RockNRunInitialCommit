using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public void Update()
    {

        Pause_Menu(); // calling the Pause function

    }



    // Pause the game
    public void Pause_Menu()

    {
        if(Input.GetKeyDown(KeyCode.P))
            {

            Time.timeScale = 0f;

        }



        // Resume the Game
        if(Input.GetKeyDown(KeyCode.R))
            {

            Time.timeScale = 1f;

        }

    }


}
