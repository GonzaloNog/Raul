using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    [Header("Audio")]
    public AudioControler auCo;
    public AudioGuia guia;
    public AudiosList audioList;
    [Header("Imagenes")]
    public ImgeList imgList;
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
    public ImgeList GetImgList()
    {
        return imgList;
    }
}
