using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    private bool _footstepsPlayed = false;
    
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
        if (_footstepsPlayed == false)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            _footstepsPlayed = true;

            _timerFinished = "pending";
        }
    }
}
