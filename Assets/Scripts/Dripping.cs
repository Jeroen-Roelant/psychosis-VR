using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dripping : MonoBehaviour
{
    private bool inTrigger;
    private GameObject faucet;
    
    // Start is called before the first frame update
    void Start()
    {
        inTrigger = false;
        faucet = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            faucet.GetComponent<AudioSource>().Pause();
            faucet.GetComponent<ParticleSystem>().Pause();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
            faucet.GetComponent<AudioSource>().Play();
            faucet.GetComponent<ParticleSystem>().Play();
        }
    }
}
