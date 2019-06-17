using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashTransition : MonoBehaviour
{
    public int timer = 2;
    // Start is called before the first frame update
    void Start()
    {
        if (timer >= 0)
        {
            SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Timer()
    {

    }
}
