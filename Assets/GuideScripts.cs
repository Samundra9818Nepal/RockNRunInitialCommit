using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideScripts : MonoBehaviour
{
    // Guide for the player to use Controls.
    public GameObject PressSpace;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            PressSpace.SetActive(true);
            Time.timeScale = 0.5f;
        }

    }

   

    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {

            Time.timeScale = 1f;
            PressSpace.SetActive(false);


        }


        if (Input.GetKeyDown(KeyCode.C))
        {

            Time.timeScale = 1f;

            PressSpace.SetActive(false);

        }



    }





}



