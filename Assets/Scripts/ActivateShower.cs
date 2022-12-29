using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateShower : MonoBehaviour
{
    public GameObject shower;
    
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

    public GameObject bathroomDoor;
    // Start is called before the first frame update
    void Start()
    {
        
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
        if (other.tag.Equals("Player"))
        {
            //bathroomDoor.GetComponent<XRGrabInteractable>().gameObject.SetActive(true);
            bathroomDoor.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 95, 0),  Time.deltaTime * 5.0f);
            shower.gameObject.GetComponent<AudioSource>().Play();
            _timerFinished = "pending";
        }
    }
}
