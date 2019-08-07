using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject scoreGO;
    public GameObject noteCountGO;
    public GameObject multiplierGO;
    public GameObject scoreBOI;

    public static int score;
    public static int currentNoteCount;
    public static int multiplier;

    /*public Text scoreT;
    public Text noteCountT;
    public Text multiplierT;*/

    void Awake ()
    {
        score = 0;
        currentNoteCount = 0;
        multiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        score = scoreBOI.GetComponent<Scores>().currentScore; //setting current score in 'Scores' script
        multiplier = scoreBOI.GetComponent<Scores>().multiplier; //setting multiplier in 'Scores' script

        //Updating UI elements
        scoreGO.GetComponent<Text>().text = "Score: " + score;
        noteCountGO.GetComponent<Text>().text = currentNoteCount.ToString();
        multiplierGO.GetComponent<Text>().text = multiplier.ToString();
    }
}