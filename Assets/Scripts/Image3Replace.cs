using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image3Replace : MonoBehaviour
{
    public Sprite[] images;
    public Image image3;
    private int currentImageIndex = 0;
    
    public void SetImage(int index)
    {
        // G,R,W,G_rabit の順で入れといてね
        image3.sprite = images[index];
        currentImageIndex = index;
    }

    public int GetCurrentImage()
    {
        return currentImageIndex;
    }
}
