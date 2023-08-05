using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    int score;

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
        IDangoInfo dangoInfo = collision.gameObject.GetComponent<IDangoInfo>();

        if (dangoInfo != null)
        {
            score += dangoInfo.Point;
            Debug.Log(score); 
            Destroy(collision.gameObject);
        }
    }

}
