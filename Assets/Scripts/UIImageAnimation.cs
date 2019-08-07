using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImageAnimation : MonoBehaviour
{
    public Color colorInitial;
    public Color color2;
    public Image spriteRef;

    public float timeBet;
     void Start()
    {
        spriteRef = GetComponent<Image>(); 
    }
    void Update()
    {
            spriteRef.color = Color.Lerp(colorInitial, color2, Mathf.PingPong(Time.time, timeBet));
    }
}
