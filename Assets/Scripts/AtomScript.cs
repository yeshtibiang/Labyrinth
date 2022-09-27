using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomScript : MonoBehaviour
{
    // vitesse de deplacement
    [SerializeField] private float speed = 4f;

    public Transform target;

    // Update is called once per frame
    void Update()
    {
        // Deplacement avec Vector3.Towards
        // on modifie automatiquement le target dès qu'on touche un target. 
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Dead");
            GameObject.Find("Player").GetComponent<PlayerController>().GameOver();
        }
    }
}
