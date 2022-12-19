using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool enterdBedRoom = false;
    public GameObject phone;
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.XR.InputTracking.disablePositionalTracking = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!enterdBedRoom)
            {
                enterdBedRoom = true;
                phone.GetComponent<AudioSource>().Play();
                phone.GetComponent<Renderer>().materials = new Material[] { mat, mat };
            }
        }
    }
}
