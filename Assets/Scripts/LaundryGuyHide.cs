using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LaundryGuyHide : MonoBehaviour
{
    public GameObject mirrorGuy;
    
    private Transform _guyTransform;

    public Vector3 normalPosition = new Vector3(-1.506f, -1.185f, 19.496f);
    public Vector3 hiddenPosition = new Vector3(-1.506f, -2.861f, 19.496f);
    
    private bool _inTrigger = false;
    private bool _sawGuy = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _guyTransform = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_inTrigger)
            Hide();
        // else if (!_inTrigger)
        //     Appear();
        
        if (_sawGuy)
            mirrorGuy.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _inTrigger = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _inTrigger = false;
        }
    }

    void Hide()
    {
        _guyTransform.position = Vector3.MoveTowards (_guyTransform.transform.position, hiddenPosition, Time.deltaTime * 1);
        _sawGuy = true;
    }

    void Appear()
    {
        _guyTransform.position = Vector3.MoveTowards (_guyTransform.transform.position, normalPosition, Time.deltaTime * 1);
    }
}
