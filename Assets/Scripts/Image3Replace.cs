using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image3Replace : MonoBehaviour
{
    public Sprite imageG;
    public Sprite imageR;
    public Sprite imageW;
    public Image image3;
    
    public void image3ToG()
    {
        image3.sprite = imageG;
        Debug.Log("image3changeG");
    }

    public void image3ToR()
    {
        image3.sprite = imageR;
        Debug.Log("image3changeR");
    }

    public void image3ToW()
    {
        image3.sprite = imageW;
        Debug.Log("image3changeW");
    }
}
