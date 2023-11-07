using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class UILevel : MonoBehaviour
{
    public TMP_InputField texto;
    public Image img;
    public GameObject item;

    private int code;
    
    public void NewAudio()
    {
        CheckNewCode();
        LevelManager.instance.getGuia().newCode(code);
    }
    public void ChecItemList()
    {
        CheckNewCode();
        if (LevelManager.instance.GetAudiosList().idiomasCount() >= code && code >= 0)
        {
            item.SetActive(true);
        }
    }
    public void RestartImage()
    {
        LevelManager.instance.GetImgList().restartImageGalery(code);
    }
    public void NewImage()
    {
        img.sprite = LevelManager.instance.GetImgList().getImagen();
    }
    public void nextIMG(bool plus)
    {
        LevelManager.instance.GetImgList().changeGaleryImg(plus);
        NewImage();
    }

    public void CheckNewCode()
    {
        string num = texto.text.Trim();
        int.TryParse(num, out int a);
        code = a;
        Debug.Log("Texto entrada: " + num);
        Debug.Log("A:" + a);
    }
}
