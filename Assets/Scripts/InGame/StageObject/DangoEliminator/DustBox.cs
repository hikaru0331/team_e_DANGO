using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustBox : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ぶつかってきたオブジェクトを破壊
        Destroy(collision.gameObject);
    }
}
