using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabitAnimator : MonoBehaviour
{
    //�A�j���[�V�����Ɋւ���ϐ�
    public SpriteRenderer rabitSprite;
    public Sprite idleSprite;
    public Sprite shotSprite;

    // Start is called before the first frame update
    void Start()
    {
        rabitSprite = GetComponent<SpriteRenderer>();
    }

    //�E�T�M�̉摜�����Ƃɖ߂��֐�
    public void SpriteResetter()
    {
        rabitSprite.sprite = idleSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
