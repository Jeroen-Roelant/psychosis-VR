using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SojaExiles;

public class HallManager : MonoBehaviour
{
    public bool start = false;
    public GameObject[] doors;
    public GameObject test;
    void OnTriggerEnter(Collider other)
    {
        test.GetComponent<PlayOnInterval>().start = true;
        start = true;
    }

    void OnTriggerExit(Collider other)
    {
        test.GetComponent<PlayOnInterval>().start = false;
        start = false;
    }
    void Start()
    {
        StartCoroutine(Action());
    }
    
    IEnumerator Action()
    {
        while (true)
        {
            if (start)
            {
                print("tset");
                var door = Random.Range(0, doors.Length);
                doors[door].GetComponent<opencloseDoor>().action = true;
            }
            yield return new WaitForSeconds(3);
        }
    }
}
