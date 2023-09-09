using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

//Filter�R��̐e�N���X
public class Filter : MonoBehaviour
{
    //�e�I�u�W�F�N�g��Transform������ϐ�
    private Transform parentTransform;

    // Start is called before the first frame update
    void Start()
    {
        //�e�I�u�W�F�N�g��Transform���擾
        parentTransform = transform.parent.GetComponent<Transform>();
        //�e�I�u�W�F�N�g�Ɛ��Ώۂ̈ʒu����
        //�I�u�W�F�N�g�̃X�^�[�g�ʒu���E�[�ƍ��[�̂ǂ���ł����������������邽��
        float moveDistination = -parentTransform.position.x;
        //�ړ����x�������_���Ɍ���
        float moveSpeed = Random.Range(2.0f, 4.0f);

        //�e�I�u�W�F�N�g�̈ړ��𐧌�
        parentTransform.DOLocalMoveX(moveDistination, moveSpeed)
           .SetEase(Ease.InOutQuad)
           .SetLoops(-1, LoopType.Yoyo);
    }

    //Filter�R��ɓ���钊�ۃ��\�b�h
    //�_���S�̐F��ς��邽�߂̃��\�b�h
    protected virtual void ChangeDangoColor()
    {
        //�o�O�h�~�p�̎��s����Ȃ�����
        Debug.Log("�I�[�o�[���C�h�����s����Ă��܂���");
    }

}
