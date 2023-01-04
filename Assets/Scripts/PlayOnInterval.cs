using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnInterval : MonoBehaviour
{
    public bool start = false;
    public GameObject gameObject;
    public int delay;
    
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
                gameObject.GetComponent<AudioSource>().Play();
            }
            yield return new WaitForSeconds(delay);
        }
    }
}
