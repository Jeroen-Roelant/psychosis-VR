using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActivateSoundIfGameObjectEnabled : MonoBehaviour
{
    public GameObject shower;
    public GameObject player;
    public AudioClip sound;

    private bool _soundPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (shower.GetComponent<AudioSource>().isPlaying && !_soundPlayed)
            {
                player.GetComponent<AudioSource>().clip = sound;
                player.GetComponent<AudioSource>().Play();
                _soundPlayed = true;
            }
        }
    }
}
