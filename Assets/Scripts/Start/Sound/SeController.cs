using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeController : MonoBehaviour
{
    private SoundManager soundManager;
    
    // Start is called before the first frame update
    void Start()
    {
        soundManager = SoundManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickButton()
    {
        Debug.Log("クリックされました");
        soundManager.seManager.PlayOneShot(soundManager.decide);
    }
}
