using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartTimer : MonoBehaviour
{
    
    public float CountDownTime = 3f;
    [SerializeField] GameObject count3;
    [SerializeField] GameObject count2;
    [SerializeField] GameObject count1;
    [SerializeField] GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.timeScale = 1;
        if(CountDownTime >= 3)
        {
            StartCoroutine("Stop");
            CountDownTime -= Time.deltaTime;
        }
        if (CountDownTime > 2 )
        {
            count3.SetActive(true);
        }
        if (CountDownTime > 1 && CountDownTime < 2)
        {
            count3.SetActive(false);
            count2.SetActive(true);
        }
        if (CountDownTime > 0 && CountDownTime < 1)
        {
            count2.SetActive(false);
            count1.SetActive(true);
        }
        if (CountDownTime < 0 && CountDownTime >= -1.0f) 
        {
            
            StartCoroutine("after_one_second");
        }
        CountDownTime -= Time.deltaTime;

    }




    IEnumerator after_one_second()
    {
        count1.SetActive(false);
        go.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        go.SetActive(false);
    }

    IEnumerator Stop()
    {

        //2•b‘Ò‚Â
        yield return new WaitForSeconds(5.0f);

        
    }
}
