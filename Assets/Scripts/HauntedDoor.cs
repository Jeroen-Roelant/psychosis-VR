using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HauntedDoor : MonoBehaviour
{
    public float openDelay = 5.0f;
    public float closeDelay = 5.0f;

    public Vector3 openRotation;
    public Vector3 closedRotation;

    private bool _isOpen = false;
    public bool doorStopped;
    public bool alreadyHappened = false;
    
    private bool _soundPlayed = false;

    private void Start()
    {
        
        StartCoroutine(OpenCloseDoor());
    }

    private void Update()
    {
        
    }

    IEnumerator OpenCloseDoor()
    {
        Debug.Log("doors haunted");
        while (true)
        {
            
            yield return new WaitForSeconds(openDelay);
            if (!doorStopped)
            {
                StartCoroutine(RotateDoor(openRotation));
                _isOpen = true;
                _soundPlayed = false;
            }


            yield return new WaitForSeconds(closeDelay);
            if (!doorStopped)
            {
                StartCoroutine(RotateDoor(closedRotation));
                _isOpen = false;
                
            }

            if (!_isOpen && !doorStopped)
            {
                if (!_soundPlayed)
                {
                    _soundPlayed = true;
                    this.GetComponent<AudioSource>().Play();
                }
            }
            
        }
    }   
    
    IEnumerator RotateDoor(Vector3 targetRotation)
    {
        float elapsedTime = 0.0f;
        float rotationTime = 1.0f; 

        while (elapsedTime < rotationTime)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(targetRotation), elapsedTime / rotationTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}