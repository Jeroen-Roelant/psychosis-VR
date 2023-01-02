using System;
using System.Collections;
using System.Collections.Generic;
using SojaExiles;
using Unity.VisualScripting;
using UnityEngine;

public class HauntCollider : MonoBehaviour
{
    public GameObject[] doors;
    public GameObject player;
    public AudioClip sound;
    
    private bool _played = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_played)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("in collider cabinet");
                foreach (var door in doors)
                {
                    door.GetComponent<HauntedDoor>().doorStopped = false;
                    Debug.Log(door.name);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (var door in doors)
            {
                door.GetComponent<HauntedDoor>().doorStopped = true;
                door.GetComponent<HauntedDoor>().alreadyHappened = true;
            }
            if (!_played)
            {
                player.GetComponent<AudioSource>().clip = sound;
                player.GetComponent<AudioSource>().Play();
                _played = true;
            }
        }
    }
}
