using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenFader : MonoBehaviour {


    public AnimationCurve Curve; // Gives the sytle to the fader.
    public Image img;

    void Start()

    {

        StartCoroutine(FadeIn());

    }

    // Scene to fade.

    public void FadeTo(string scene)
    {


        StartCoroutine(FadeOut(scene));


    }


    // Making the screen fadeIn.
    IEnumerator FadeIn()

    {


        float t = 1f;


        // Checking if the Time value is greater than 0 then animate the screen with fader.
        while (t > 0f)
        { 
            t -= Time.deltaTime; // Decreasing the Time variable.
  
            float a = Curve.Evaluate(t); // chnage the fader accourding to curve made.

            img.color = new Color(0f, 0f, 0f, a); // giving black color.

            yield return 0; // It will skip or wait for the next frame.


        }

    }


    //  // Making the screen fade out.
    IEnumerator FadeOut(string scene)

    { 
        // Giving the float time
        float t = 0f;

        // Checking the condition.
        while (t < 1f)
        {


            t += Time.deltaTime;

            float a = Curve.Evaluate(t);

            img.color = new Color(0f, 0f, 0f, a);

            yield return 0;


        }
        // After all the fadeout is done it will load the scene.
        SceneManager.LoadScene(scene);


    }
}
