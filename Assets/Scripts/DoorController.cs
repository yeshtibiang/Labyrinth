using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    private Animator _animator;
    private AudioSource _audio;
    public bool CanOpen = false;

    [SerializeField] private AudioClip sonOpen, sonNoOpen;
    [SerializeField] private Animator _doorOpenAnimator;
    [SerializeField] private GameObject _particuleOut;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
        //_animator = GetComponent<Animator>();
    }

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && CanOpen)
        {
            _particuleOut.SetActive(true);
            _doorOpenAnimator.enabled = true;
            // lorsque le player a la clé
            _audio.PlayOneShot(sonOpen);
        }
        else
        {
            _audio.PlayOneShot(sonNoOpen);
        }
    }
}
