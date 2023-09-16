using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class ButtonDisplay : MonoBehaviour
{
    public GameObject buttonRetry;
    public GameObject buttonEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async void ShowButtons()
    {
        await Task.Delay(1000); // 1秒待つ

        buttonRetry.SetActive(true);
        buttonEnd.SetActive(true);
    }
}
