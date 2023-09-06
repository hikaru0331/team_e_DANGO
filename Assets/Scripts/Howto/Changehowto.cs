using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changehowto : MonoBehaviour
{
    public GameObject Howto1;
    public GameObject Howto2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeHowto()
    {
      // 遊び方画像変更
      Howto1.SetActive(false);
      Howto2.SetActive(true);
    }
}
