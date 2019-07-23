using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public Color colorInitial;
    public Color color2;
    public SpriteRenderer spriteRef;
    void Start()
    {
        spriteRef = GetComponent<SpriteRenderer>();
        colorInitial = spriteRef.color;
        color2 = new Color(0, 170, 255);
    }

    // Update is called once per frame
    void Update()
    {
        spriteRef.color = Color.Lerp(colorInitial, color2, Mathf.PingPong(Time.time,1));
    }
}
