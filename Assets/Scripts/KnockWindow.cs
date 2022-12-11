using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockWindow : MonoBehaviour
{
    private GameObject window;
    // Start is called before the first frame update
    void Start()
    {
        window = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("yoyoyoo");
        window.GetComponent<AudioSource>().Play();
    }
}
