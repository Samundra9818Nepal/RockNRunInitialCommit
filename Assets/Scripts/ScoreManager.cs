using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int noteCount;
    public int multiplier;
    public string totalNoteCount;

    Text scoreT;
    Text noteCountT;
    Text multiplierT;
    void Awake ()
    {
        score = 0;
        noteCount = 0;
        multiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreT.text = "Score: " + score;
        noteCountT.text = noteCount.ToString();
        multiplierT.text = multiplier.ToString();
    }
}
