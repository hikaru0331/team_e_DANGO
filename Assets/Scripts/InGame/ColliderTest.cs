using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private int score;
    public Sprite dangoSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�C���^�[�t�F�[�X�Ƃ��ėp�ӂ����N���X�̃C���X�^���X��
        //�_���S�ɒ��ڃA�^�b�`����Ă��Ȃ����A�A�^�b�`����Ă���N���X(DangoG�Ȃ�)�̐e�N���X�̂��ߎ擾�\
        IDangoInfo dangoInfo = collision.gameObject.GetComponent<IDangoInfo>();

        if (dangoInfo != null)
        {
            score += dangoInfo.Point;
            Debug.Log(score); 
            Destroy(collision.gameObject);
        }

        //�S�[���Ƀ_���S���h����鏈��
        //�G��Ă����I�u�W�F�N�g��Sprite�̏����擾���S�[����Sprite�ɑ��
        //�����ł͊ȈՉ��̂��߂ɋ���Sprite���̂��̂��_���S�ɕύX���Ă���
        SpriteRenderer spriteRenderer = collision.gameObject.GetComponent<SpriteRenderer>();
        dangoSprite = spriteRenderer.sprite;
        
        this.gameObject.GetComponent<SpriteRenderer>().sprite = dangoSprite;

    }

}
