using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgmControl : MonoBehaviour
{
    private AudioSource BgmManager;
    public Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        // BgmManagerを探して取得
        BgmManager = GameObject.Find("BgmManager").GetComponent<AudioSource>();

        // スライダーの初期値を設定
        volumeSlider.value = BgmManager.volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnVolumeSliderChanged()
    {
        // スライダーの値に基づいて音量を変更
        BgmManager.volume = volumeSlider.value;
        Debug.Log("BGMの音量を" + BgmManager.volume + "に変更しました。");
    }
}
