using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UILevel : MonoBehaviour
{
    public TMP_InputField texto;
    
    public void NewAudio()
    {
        string num = texto.text.Trim();
        int.TryParse(num , out int a);
        Debug.Log("Texto entrada: " + num);
        Debug.Log("A:" + a);
        LevelManager.instance.getGuia().newCode(a);
    }
}
