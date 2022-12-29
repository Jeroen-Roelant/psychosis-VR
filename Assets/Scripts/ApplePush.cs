using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePush : MonoBehaviour
{
    public GameObject[] apples;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
            foreach (var apple in apples)
            {
                apple.GetComponent<Push>().enabled = true;
            }
    }
}
