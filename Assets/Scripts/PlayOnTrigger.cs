using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnTrigger : MonoBehaviour
{

    private void Start()
    {
        this.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
        this.GetComponent<UnityEngine.Video.VideoPlayer>().Pause();
    }
    private void Update()
    {
        if (!this.GetComponent<UnityEngine.Video.VideoPlayer>().isPlaying)
        {
            this.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
            this.GetComponent<UnityEngine.Video.VideoPlayer>().Pause();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (!this.GetComponent<UnityEngine.Video.VideoPlayer>().isPlaying)
            {
                this.GetComponent<UnityEngine.Video.VideoPlayer>().frame = 0;
                this.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
            }
        }
    }
}
