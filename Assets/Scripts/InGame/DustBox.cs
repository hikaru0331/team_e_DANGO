using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DustBox : MonoBehaviour
{
    private Transform parentTransform;

    // Start is called before the first frame update
    void Start()
    {
        parentTransform = transform.parent.GetComponent<Transform>();

        parentTransform.DOLocalMoveX(3.5f, 5.0f)
           .SetEase(Ease.InOutQuad)
           .SetLoops(-1, LoopType.Yoyo);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
