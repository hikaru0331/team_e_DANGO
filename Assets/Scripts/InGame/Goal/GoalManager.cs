using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public IDangoInfo dangoInfo;

    private ScoreManager scoreManager;
    private GoalSpriteManager goalSpriteManager;

    private void Start()
    {
        scoreManager = this.gameObject.GetComponent<ScoreManager>();
        goalSpriteManager = this.gameObject.GetComponent<GoalSpriteManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�C���^�[�t�F�[�X�Ƃ��ėp�ӂ����N���X�̃C���X�^���X��
        //�_���S�ɒ��ڃA�^�b�`����Ă��Ȃ����A�A�^�b�`����Ă���N���X(DangoG�Ȃ�)�̐e�N���X�̂��ߎ擾�\
        dangoInfo = collision.gameObject.GetComponent<IDangoInfo>();

        if (dangoInfo != null)
        {
            //ScoreManager�N���X�̃X�R�A�v�Z���\�b�h�ɃX�R�A��n��
            scoreManager.PointCalculator(dangoInfo.Point);

            //SpriteManager�N���X�̃X�v���C�g�ϊ����\�b�h�ɃX�R�A��n��
            goalSpriteManager.SpriteChanger(dangoInfo.Sprite);

            //�Ń_���S�������Ƃ��ɃQ�[���I�[�o�[�ɂ��鏈��
            if (dangoInfo.Attribute == "Poison")
            {
                //Debug.Log("GameOver");
            }

            Destroy(collision.gameObject);
        }

    }

}
