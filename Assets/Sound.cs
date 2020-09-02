using UnityEngine.Audio;
using UnityEngine;
[System.Serializable]
public class Sound
{
    //creates Soud class for use by the Audio Manager
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;

    [HideInInspector]
    public AudioSource source;
}
