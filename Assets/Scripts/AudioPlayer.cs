
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip[] audioClips;
    public GameObject player;
    
    private int _currentClipIndex = 0;
    private AudioSource _audioSource;
    private bool _played = false;

    void Start()
    {
        _audioSource = player.GetComponent<AudioSource>();
        
        
        _audioSource.clip = audioClips[_currentClipIndex];
        if (!_played)
            _audioSource.Play();
    }

    void Update()
    {
        if (!_audioSource.isPlaying && !_played)
        {
            _currentClipIndex++;

            if (_currentClipIndex >= audioClips.Length)
            {
                _played = true;
            }

            if (_currentClipIndex < audioClips.Length)
            {
                _audioSource.clip = audioClips[_currentClipIndex];
                _audioSource.Play();
            }
        }
    }
}
