using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Continue()
    {
        // si la clé n'existe pas cela renvoie 0. 
        int levelToLoad = PlayerPrefs.GetInt("LastLevel");
        if (levelToLoad > 1)
        {
            // load the scene with the index
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
