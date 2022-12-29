using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockWindow : MonoBehaviour
{
    private GameObject _window;


    private string _timerFinished = "false";
    public float timer = 100f;
    
    public AudioClip audioClip;
    public GameObject player;

    void ActivateTimer()
    {
        timer = -Time.deltaTime;

        if (timer <= 0f)
            _timerFinished = "true";
    }
    // Start is called before the first frame update
    void Start()
    {
        _window = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (_timerFinished == "pending")
        {
            ActivateTimer();
        }
        if (_timerFinished == "true")
        {
            player.GetComponent<AudioSource>().clip = audioClip;
            player.GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _window.GetComponent<AudioSource>().Play();
        player.GetComponent<AudioSource>().clip = audioClip;
        _timerFinished = "pending";
    }
}
