using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class DissapearOnGrab : MonoBehaviour
{
    public bool active = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (active)
        {
            dissapear();
        }
    }

    void dissapear()
    {
        this.gameObject.SetActive(false);
    }
}
