using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgmController : MonoBehaviour
{
    private AudioSource bgmManager;
    public AudioClip bgm;
    public AudioClip bgm_ingame;
    public AudioClip bgm_result;
    private string beforeScene;
    
    // Start is called before the first frame update
    void Start()
    {
        bgmManager = GetComponent<AudioSource>();
        beforeScene = "Start";

        bgmManager.clip = bgm;  // AudioClipを指定
        bgmManager.Play();
        
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {      
        //シーンがどう変わったかで判定
        // HowtoからCountへ
        if (beforeScene == "Howto" && nextScene.name == "Count")
        {
            bgmManager.Stop();  // BGMを止める
        }
        
        // Countからingameへ
        if (beforeScene == "Count" && nextScene.name == "test")
        {
            bgmManager.clip = bgm_ingame; // BGMを切り替える
            bgmManager.Play();
        }

        // ingameからResultへ
        if (beforeScene == "test" && nextScene.name == "Result")
        {
            bgmManager.Stop();
            bgmManager.clip = bgm_result;
            bgmManager.Play();
        }

        // ResultからCountへ
        if (beforeScene == "Result" && nextScene.name == "Count")
        {
            bgmManager.Stop();
            bgmManager.clip = bgm_ingame;
            bgmManager.Play();
        }

        //遷移後のシーン名を「１つ前のシーン名」として保持
        beforeScene = nextScene.name;
    }
}
