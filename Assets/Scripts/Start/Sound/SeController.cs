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
        soundManager.seManager.PlayOneShot(soundManager.decide);
        Debug.Log("クリックされました");
    }

    public void PlayCountdown()
    {
        soundManager.seManager.PlayOneShot(soundManager.countdown);
        Debug.Log("カウントダウン開始");
    }

    public void PlayStart()
    {
        soundManager.seManager.PlayOneShot(soundManager.start);
        Debug.Log("スタート");
    }
}
