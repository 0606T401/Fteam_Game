using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowArea : MonoBehaviour
{
    public float SlowTime = 0.5f;
    bool slow = false;
    bool XbuttonFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        
        if (col.gameObject.name=="SlowArea")
        {
            
            if (Input.GetButton("Xbutton") && !slow && !XbuttonFlag) 
            {
                Debug.Log("Slow");
                Time.timeScale = SlowTime;
                slow = true;
                XbuttonFlag = true;
            }
            else if(Input.GetButton("Xbutton") && slow&& !XbuttonFlag)
            {
                Debug.Log("Slow cancel");
                Time.timeScale = 1;
                slow = false;
                XbuttonFlag = true;
            }

            if (Input.GetButton("Xbutton") == false && XbuttonFlag == true)
            {
                XbuttonFlag = false;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "SlowArea")
        {
            Debug.Log("OutSlowArea");
            Time.timeScale = 1;
            slow = false;
        }
    }
}
