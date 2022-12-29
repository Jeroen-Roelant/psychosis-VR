using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopMail : MonoBehaviour
{
    public GameObject Laptop;
    public Material LaptopMaterial;

    private bool MailReceived = false;
    
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
        if (MailReceived == false)
        {
            Laptop.gameObject.GetComponent<AudioSource>().Play();
            Laptop.gameObject.GetComponent<Renderer>().material = LaptopMaterial;
            MailReceived = true;
            
            player.GetComponent<AudioSource>().clip = audioClip;
            player.GetComponent<AudioSource>().Play();
            
            //_timerFinished = "pending";
        }
    }
}
