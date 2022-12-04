using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerOpen : MonoBehaviour
{
    public GameObject showerGuy;

    public GameObject shower;

    public GameObject showerObject;
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
        if (other.name.Equals("GlassDoor"))
        {
            showerGuy.gameObject.SetActive(false);
            showerObject.gameObject.SetActive(false);
            shower.GetComponent<ParticleSystem>().Stop();
        }
    }
}
