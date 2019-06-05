using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{


    public string LevelName = "Scene 2";



    //Load New Scene

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {


            SceneManager.LoadScene(LevelName);

        }

    }

}
