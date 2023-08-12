using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FilterGreen : MonoBehaviour
{
    private Transform parentTransform;

    // Start is called before the first frame update
    void Start()
    {
        parentTransform = transform.parent.GetComponent<Transform>();

        parentTransform.DOLocalMoveX(3.5f, 3.0f)
           .SetEase(Ease.InOutQuad)
           .SetLoops(-1, LoopType.Yoyo);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDangoInfo dangoInfo = collision.gameObject.GetComponent<IDangoInfo>();

        if (dangoInfo != null)
        {
            Debug.Log("a");
            //Destroy(collision.gameObject);
        }
    }
}
