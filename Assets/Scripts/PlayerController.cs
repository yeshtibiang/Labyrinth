using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;
    private float curSpeed;

    [SerializeField] private GameObject gameOver;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            curSpeed = moveSpeed * 2;
        }
        else
        {
            curSpeed = moveSpeed;
        }
        // rotation
        transform.Rotate(Vector3.up * 80 * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.forward * curSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
    }

    public void GameOver()
    {
        //GameObject.Find("GameOver").SetActive(true);
        gameOver.SetActive(true);
        // je demarre ma coroutine
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");
    }
}
