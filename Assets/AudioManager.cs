using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            //pass through array of audio files
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
        }
    }
    public void Play(string name)
    {   
        // Creates method that plays actual audio file
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
