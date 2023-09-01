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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartIllustrationAnimation()
    {
        // ボタンがハイライトされている場合、ウサギのアニメーションを再生
        if(ButtonHover.GetCurrentAnimatorStateInfo(0).IsName("Highlighted"))
        {
            RabbitHover.SetTrigger("Highlighted");
            Debug.Log("Highlighted");
        }
    }
}