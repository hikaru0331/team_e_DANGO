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
        Debug.Log("imagechange");
    }
}
