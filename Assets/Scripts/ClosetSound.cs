using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetSound : MonoBehaviour
{
    private bool _closetSoundsPlayed = false;
    
    private string _timerFinished = "false";
    public float timer = 5f;
    private bool _soundPlayed = false;
    
    public AudioClip audioClip;
    public GameObject player;

    private void ActivateTimer()
    {
        timer -= Time.deltaTime;

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
        if (_timerFinished == "true" && !_soundPlayed)
        {
            player.GetComponent<AudioSource>().clip = audioClip;
            player.GetComponent<AudioSource>().Play();
            _soundPlayed = true;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (_closetSoundsPlayed == false)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            _closetSoundsPlayed = true;

            _timerFinished = "pending";
        }
    }
}
