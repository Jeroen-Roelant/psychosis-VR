using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LaundryGuyHide : MonoBehaviour
{
    public Transform guyTransform;

    public Vector3 normalPosition = new Vector3(-1.506f, -1.185f, 19.496f);
    public Vector3 hiddenPosition = new Vector3(-1.506f, -2.861f, 19.496f);
    
    private bool inTrigger = false;
    
    // Start is called before the first frame update
    void Start()
    {
        guyTransform = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!inTrigger)
        {
            Appear();
        }
        else
        {
            Hide();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
        }
    }

    void Hide()
    {
        guyTransform.position = Vector3.MoveTowards (guyTransform.transform.position, hiddenPosition, Time.deltaTime * 1);
    }

    void Appear()
    {
        guyTransform.position = Vector3.MoveTowards (guyTransform.transform.position, normalPosition, Time.deltaTime * 1);
    }
}
