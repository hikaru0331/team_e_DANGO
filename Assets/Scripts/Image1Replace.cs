using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image1Replace : MonoBehaviour
{
    public Sprite imageG;
    public Sprite imageR;
    public Sprite imageW;
    public Image image1;
    
    public void image1ToG()
    {
        image1.sprite = imageG;
        Debug.Log("image1changeG");
    }

    public void image1ToR()
    {
        image1.sprite = imageR;
        Debug.Log("image1changeR");
    }

    public void image1ToW()
    {
        image1.sprite = imageW;
        Debug.Log("image1changeW");
    }
}
