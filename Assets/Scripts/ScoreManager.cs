using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    Image1Replace a;

    // Start is called before the first frame update
    void Start()
    {
        //image非表示
        image1.enabled = false;
        image2.enabled = false;
        image3.enabled = false;

        a = GetComponentInChildren<Image1Replace>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "dangoG(Clone)" )
        {
            image1.enabled = true;
            a.image1ToG();
        }
        Destroy(other.gameObject);
        Debug.Log("Goal!!");
    }
}
