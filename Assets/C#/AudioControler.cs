using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControler : MonoBehaviour
{
    private AudioSource aud;
    void Start()
    {
        aud = GetComponent<AudioSource>();
        aud.volume = ConfigManager.instance.volumen;
    }
    public AudioSource getAudioSourceAC()
    {
        return aud;
    }
}
