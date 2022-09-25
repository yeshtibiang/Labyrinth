using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject.Find("DoorExitPoint").GetComponent<DoorController>().CanOpen = true; 
            Destroy(gameObject);
        }
    }
}
