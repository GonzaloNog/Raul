using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigManager : MonoBehaviour
{
    public static ConfigManager instance;
    public float volumen;
    public string language;
    private int languageCode;
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
    public void Start()
    {
        language = "en";
        languageCode = 0;
    }
    public void setLanguage(string lan)
    {
        language = lan;
        Debug.Log("Nuevo idioma: " + language);
        setLanguageCode();
    }
    private void setLanguageCode()
    {
        switch (language)
        {
            case "en":
                languageCode = 0;
                break;
            case "es":
                languageCode = 1;
                break;
            case "fr":
                languageCode = 2;
                break;
        }
    }
    public int getLanguageCode()
    {
        return languageCode;
    }
}
