using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LoadingManager : MonoBehaviour
{


    public Slider LOADING; // Attaching the loading UI
    public Text Percentages;
    public float TimeToLoad = 0.8f;
    public ScreenFader Fader;
    public string LevelToload = " Rock 2";


    // Text for showing loading progress in %.
  public void TextUpdate(float value)
    {


        Percentages.text = Mathf.RoundToInt(value * 1f) + "%";
    }


    // Creating loading values.
    private void Update()
    {

        if (LOADING.value > 0f)
        {

            LOADING.value += TimeToLoad;
            Debug.Log("Loading");


        }

        if (LOADING.value == 100f)
        {


            Fader.FadeTo(LevelToload);


        }

    }



}
