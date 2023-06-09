using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image2Replace : MonoBehaviour
{
    public Sprite imageG;
    public Sprite imageR;
    public Sprite imageW;
    public Image image2;
    
    public void image2ToG()
    {
        image2.sprite = imageG;
        Debug.Log("image2changeG");
    }

    public void image2ToR()
    {
        image2.sprite = imageR;
        Debug.Log("image2changeR");
    }

    public void image2ToW()
    {
        image2.sprite = imageW;
        Debug.Log("image2changeW");
    }
}
