using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartTimer : MonoBehaviour
{
    
    public float CountDownTime = 3f;
    public TextMeshProUGUI CountDownTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1;
        if(CountDownTime >= 3)
        {
            StartCoroutine("Stop");
            CountDownTime -= Time.deltaTime;
        }
        if (CountDownTime > 0)
        {
            CountDownTimer.text = string.Format("{0:0}", CountDownTime);
        }
        if (CountDownTime < 0 && CountDownTime >= -1.0f) 
        {
            CountDownTimer.text = string.Format("GO!");
            StartCoroutine("after_one_second");
            
        }
        CountDownTime -= Time.deltaTime;

    }




    IEnumerator after_one_second()
    {
        yield return new WaitForSeconds(1.0f);
        CountDownTimer.text = string.Format("");
    }

    IEnumerator Stop()
    {

        //2�b�҂�
        yield return new WaitForSeconds(5.0f);

        
    }
}
