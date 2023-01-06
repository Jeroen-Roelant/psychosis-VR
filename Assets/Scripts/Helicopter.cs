using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    private Vector3 _startPosition;
    private Vector3 _endPosition;
    private bool _on;
    
    public Transform endPoint;
    public float speed;
    public GameObject player;
    public AudioClip sound;
    
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = this.gameObject.transform.position;
        _endPosition = endPoint.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        HelicopterFlight(_on);
    }

    void HelicopterFlight(bool on)
    {
        if(on)
        {
            var step =  speed * Time.deltaTime;
            this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, _endPosition, step);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _on = true;
        this.gameObject.GetComponent<AudioSource>().Play();
        Debug.Log("HELIKOPTER HELIKOPTER");
    }

    private void OnTriggerExit(Collider other)
    {
        player.GetComponent<AudioSource>().clip = sound;
        player.GetComponent<AudioSource>().Play();
    }
}
