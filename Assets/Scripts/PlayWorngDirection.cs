using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWorngDirection : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.GetComponent<AudioSource>().Play();
        }
    }
}
