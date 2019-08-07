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

    // Start is called before the first frame update
    void Start()
    {
        Scores s = scoreboi.GetComponent<Scores>();
        
        level1.text = s.score[0];
        level1.text = s.score[0];
        level2.text = s.score[1];
        level3.text = s.score[2];
        level4.text = s.score[3];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
