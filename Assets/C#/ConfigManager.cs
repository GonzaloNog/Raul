using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigManager : MonoBehaviour
{
    public static ConfigManager instance;
    public float volumen;
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
        DontDestroyOnLoad(this);
    }
}
