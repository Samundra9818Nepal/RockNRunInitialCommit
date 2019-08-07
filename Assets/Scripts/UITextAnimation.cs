﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextAnimation : MonoBehaviour
{
    public Color colorInitial;
    public Color color2;
    public Text textRef;

    public float timeBet;
    void Start()
    {
        textRef = GetComponent<Text>();
    }
    void Update()
    {
        textRef.color = Color.Lerp(colorInitial, color2, Mathf.PingPong(Time.time, timeBet));
    }
}
