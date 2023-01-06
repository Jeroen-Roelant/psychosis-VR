using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnEnter : MonoBehaviour
{
    public GameObject player;
    public AudioClip sound;

    private bool _played = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("enter");
            if (!_played)
            {
                player.GetComponent<AudioSource>().clip = sound;
                player.GetComponent<AudioSource>().Play();
                _played = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (_played)
        {
            player.GetComponent<AudioSource>().Stop();
        }
    }
}
