using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOption : MonoBehaviour
{
  public GameObject RabbitIdleOp;
  public GameObject RabbitPushOp;

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
      RabbitIdleOp.SetActive(false);
      RabbitPushOp.SetActive(true);
      
      SceneManager.LoadScene("Option");
    }
}
