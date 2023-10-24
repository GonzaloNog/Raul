using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGuia : MonoBehaviour
{

    public void newCode(int num)
    {
        LevelManager.instance.getAudioControler().getAudioSourceAC().Stop();
        LevelManager.instance.getAudioControler().getAudioSourceAC().clip = LevelManager.instance.GetAudiosList().getAudioClip(num);
        LevelManager.instance.getAudioControler().getAudioSourceAC().Play();
    }
}
