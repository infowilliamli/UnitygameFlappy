using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public string SceneName;

    public void loadLevel()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
