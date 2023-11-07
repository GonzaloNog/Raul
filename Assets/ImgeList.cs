using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImgeList : MonoBehaviour
{
    public Sprite errorImg;
    private int index;
    private int indexMax;
    private int actualIMG;
    [System.Serializable]


    public struct Galeria
    {
        public Sprite[] img;
    }
    public Galeria[] galerias;

    public Sprite getImagen()
    {
        if (galerias[actualIMG].img.Length >= actualIMG && actualIMG >= 0)
        {
            if (galerias[actualIMG].img[index] != null)
                return galerias[actualIMG].img[index];
        }
        return errorImg;
    }
    public void restartImageGalery(int code)
    {
        index = 0;
        actualIMG = code;
    }
    public void changeGaleryImg(bool plus)
    {
        if (plus)
        {
            if (index < (galerias[actualIMG].img.Length - 1))
                index++;
            else
                index = 0;
        }
        else
        {
            if (index > 0 )
                index--;
            else
                index = (galerias[actualIMG].img.Length - 1);
        }
    }
}
