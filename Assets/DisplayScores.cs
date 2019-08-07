using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScores : MonoBehaviour
{

    public GameObject scoreboi;
    public Text level1;
    public Text level2;
    public Text level3;
    public Text level4;

    private void Awake()
    {
        scoreboi.GetComponent<Scores>().OnRead += text;
    }

    void text()
    {
        Scores s = scoreboi.GetComponent<Scores>();

        level1.text = s.score[0];
        level2.text = s.score[1];
        level3.text = s.score[2];
        level4.text = s.score[3];

    }
}
