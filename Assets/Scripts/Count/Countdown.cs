using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    private TextMeshProUGUI counttext;

    // Start is called before the first frame update
    void Start()
    {
        counttext = GetComponent<TextMeshProUGUI>();
        
        StartCoroutine(CountdownCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CountdownCoroutine()
    {
        counttext.text = "3";
        yield return new WaitForSeconds(1.0f);
 
		counttext.text = "2";
		yield return new WaitForSeconds(1.0f);
 
		counttext.text = "1";
		yield return new WaitForSeconds(1.0f);
		
		counttext.text = "GO!";
    }
}
