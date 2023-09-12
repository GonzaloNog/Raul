using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int dificultad = 0;
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

    //SET and GET
    public void setDificultad(int a)
    {
        dificultad = a;
    }
    public int getDificultad()
    {
        return dificultad;
    }
}
