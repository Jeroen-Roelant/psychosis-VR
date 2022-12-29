using System;
using System.Collections;
using System.Collections.Generic;
using SojaExiles;
using UnityEngine;

public class CabinetDoors : MonoBehaviour
{
    public GameObject[] cabinetDoors;
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
        foreach (var c in cabinetDoors)
        {
            
        }
    }
}
