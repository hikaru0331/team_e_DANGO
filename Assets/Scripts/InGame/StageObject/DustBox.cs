using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DustBox : MonoBehaviour
{
    //�S�~���̐e�I�u�W�F�N�g��Transform������ϐ�
    //�S�~���{�̂ƍ폜���������R���C�_�[��ʃI�u�W�F�N�g�ɂ��Ă��邽��
    private Transform parentTransform;

    // Start is called before the first frame update
    void Start()
    {
        //�e�I�u�W�F�N�g��Transform���擾
        parentTransform = transform.parent.GetComponent<Transform>();
        //�e�I�u�W�F�N�g�Ɛ��Ώۂ̈ʒu����
        float moveDistination = -parentTransform.position.x;

        //�e�I�u�W�F�N�g�̈ړ��𐧌�
        parentTransform.DOLocalMoveX(moveDistination, 10.0f)
           .SetEase(Ease.InOutQuad)
           .SetLoops(-1, LoopType.Yoyo);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�Ԃ����Ă����I�u�W�F�N�g��j��
        Destroy(collision.gameObject);
    }
}
