using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateShower : MonoBehaviour
{
    public GameObject shower;

    public GameObject bathroomDoor;
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
        if (other.tag.Equals("Player"))
        {
            Debug.Log("bububuubub");
            bathroomDoor.GetComponent<XRGrabInteractable>().gameObject.SetActive(true);
            shower.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
