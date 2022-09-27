using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(GetBackToMenu());
    }

    public IEnumerator GetBackToMenu()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Menu");
    }
}
