using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Radio : MonoBehaviour
{
    public GameObject player;
    public GameObject controller;
    public GameObject locomotion;
    
    public AudioClip sound;
    private GameObject _this;
    private bool _radioFinished = false;
    private bool _soundPlayed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _this = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (_radioFinished)
        {
            if (!this.GetComponent<AudioSource>().isPlaying)
            {
                if (!_soundPlayed)
                {
                    player.GetComponent<AudioSource>().clip = sound;
                    player.GetComponent<AudioSource>().Play();
                    _soundPlayed = true;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("triggered");
        if (other.gameObject.tag == "Player")
        {
            if (!_radioFinished)
            {
                this.GetComponent<AudioSource>().Play();
                _radioFinished = true;
            }
        }
    }
}
