using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockWindow : MonoBehaviour
{
    private GameObject _window;
    private bool _knockPlayed = false;
    
    private string _timerFinished = "false";
    public float timer = 5f;
    private bool _soundPlayed = false;
    
    public AudioClip audioClip;
    public GameObject player;

    void ActivateTimer()
    {
        timer -= Time.deltaTime;

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
        if (_timerFinished == "true"&& !_soundPlayed)
        {
            player.GetComponent<AudioSource>().clip = audioClip;
            player.GetComponent<AudioSource>().Play();
            _soundPlayed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_knockPlayed)
        {
            _window.GetComponent<AudioSource>().Play();
            _knockPlayed = true;

            _timerFinished = "pending";
        }
    }
}
