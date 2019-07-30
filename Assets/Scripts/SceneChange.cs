using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{


public void changeToScene(int changeTheScene)
{
    SceneManager.LoadScene(changeTheScene);
}
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

}
