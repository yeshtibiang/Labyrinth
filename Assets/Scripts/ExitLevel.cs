using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    
    // index de la scene dans le build
    [SerializeField] private int levelToLoad;
    // si on veut que la scene suivante soit automatiquement choisit
    [SerializeField] private bool autoIndex;

    private void Start()
    {
        if (autoIndex)
        {
            // charger dynamiquement la scene
            levelToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt("LastLevel", levelToLoad);
            SceneManager.LoadScene(levelToLoad);
        }
            
    }
}
