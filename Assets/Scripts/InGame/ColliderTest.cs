using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private int score;
    [System.NonSerialized] public Sprite dangoSprite;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�C���^�[�t�F�[�X�Ƃ��ėp�ӂ����N���X�̃C���X�^���X��
        //�_���S�ɒ��ڃA�^�b�`����Ă��Ȃ����A�A�^�b�`����Ă���N���X(DangoG�Ȃ�)�̐e�N���X�̂��ߎ擾�\
        IDangoInfo dangoInfo = collision.gameObject.GetComponent<IDangoInfo>();

        if (dangoInfo != null)
        {
            //�_���S�Ɋi�[����Ă���X�R�A�����擾���ĉ��Z���鏈��
            score += dangoInfo.Point;
            Debug.Log(score);

            //�S�[���Ƀ_���S���h����鏈��
            //�G��Ă����I�u�W�F�N�g��Sprite�̏����擾���S�[����Sprite�ɑ��
            //�����ł͊ȈՉ��̂��߂ɋ���Sprite���̂��̂��_���S�ɕύX���Ă���
            this.gameObject.GetComponent<SpriteRenderer>().sprite = dangoInfo.Sprite;

            //�Ń_���S�������Ƃ��ɃQ�[���I�[�o�[�ɂ��鏈��
            if (dangoInfo.Attribute == "Poison")
            {
                Debug.Log("GameOver");
            }

            Destroy(collision.gameObject);
        }
        
    }

}
