using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image1Replace : MonoBehaviour
{
    public Sprite[] images;
    public Image image1;
    
    public void SetImage(int index)
    {
        // G,R,W,G_rabit の順で入れといてね
        image1.sprite = images[index];
    }
}
