using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnScript : MonoBehaviour
{
    // the target
    [SerializeField] private Transform target;

    [SerializeField] private AtomScript atomScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
            atomScript.target = target;
    }
}
