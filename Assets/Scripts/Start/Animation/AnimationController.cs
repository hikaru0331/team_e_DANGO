using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    public Button button;
    public GameObject illustration;

    private Animator ButtonHover;
    private Animator RabbitHover;

    // Start is called before the first frame update
    void Start()
    {
        ButtonHover = button.GetComponent<Animator>();
        RabbitHover = illustration.GetComponent<Animator>();
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartIllustrationAnimation()
    {
        bool isButtonHighlighted = ButtonHover.GetBool("Highlighted");   // ボタンのハイライト状態を取得
        Debug.Log(isButtonHighlighted);

        // ボタンがハイライトされている場合、ウサギのアニメーションを再生
        if(isButtonHighlighted)
        {
            RabbitHover.SetTrigger("Highlighted");
            Debug.Log("Highlighted");
        }
    }
}