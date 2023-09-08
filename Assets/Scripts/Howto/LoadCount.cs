using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCount : MonoBehaviour
{
    public GameObject Howto1;
    public GameObject Howto2;

    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
      if(count == 0)
      {
        // 遊び方画像変更
        Howto1.SetActive(false);
        Howto2.SetActive(true);
        count++;
      }
      else
      {
        SceneManager.LoadScene("Count");
      }
    }
}
