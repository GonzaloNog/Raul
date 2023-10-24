using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public AudioControler auCo;
    public AudioGuia guia;
    public AudiosList audioList;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public AudioControler getAudioControler()
    {
        return auCo;
    }
    public AudioGuia getGuia()
    {
        return guia;
    }
    public AudiosList GetAudiosList()
    {
        return audioList;
    }
}
