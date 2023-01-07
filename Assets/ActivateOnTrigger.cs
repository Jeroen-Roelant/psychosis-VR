using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActivateOnTrigger : MonoBehaviour
{
    public GameObject ifActiveObject;
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
        if (ifActiveObject.active && other.tag == "Player")
        {
            this.gameObject.SetActive(true);
        }
    }
}
