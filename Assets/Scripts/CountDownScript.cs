using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour
{

    [SerializeField] private int startCountDown = 60;

    [SerializeField] private Text txtCountDown;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Pause());
        txtCountDown.text = "Time Left: " + startCountDown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Pause()
    {
        while (startCountDown > 0)
        {
            yield return new WaitForSeconds(1f);
            startCountDown--;
            txtCountDown.text = "Time Left: " + startCountDown;
        }
        
        // si fin de countdown alors GameOver
        GameObject.Find("Player").GetComponent<PlayerController>().GameOver();
        
    }
}
