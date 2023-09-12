using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public Slider volumenS;

    public void Start()
    {
        volumenS.value = ConfigManager.instance.volumen;
    }
    public void newLevel(int levelID)
    {
        SceneManager.LoadScene(levelID);
    }
    public void newLevelString(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void changeVolum()
    {
        ConfigManager.instance.volumen = volumenS.value;
    }
}
