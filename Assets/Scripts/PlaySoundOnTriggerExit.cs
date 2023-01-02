using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlaySoundOnTriggerExit : MonoBehaviour
{
    public GameObject player;
    public AudioClip sound;
    
    private bool _played = false;

    private void OnTriggerExit(Collider other)
    {
        if (!_played)
        {
            player.GetComponent<AudioSource>().clip = sound;
            player.GetComponent<AudioSource>().Play();
            _played = true;
        }
    }
}
