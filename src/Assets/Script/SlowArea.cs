using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowArea : MonoBehaviour
{
    public Data data;
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
                data.fallspeed = data.fallspeed / 2;
                slow = true;
                XbuttonFlag = true;
            }
            
            if(Input.GetButton("Xbutton") && slow&& !XbuttonFlag)
            {
                Debug.Log("Slow cancel");
                data.fallspeed = data.fallspeed * 2;
                slow = false;
                XbuttonFlag = true;
            }

            if (Input.GetButton("Xbutton") == false && XbuttonFlag == true)
            {
                Debug.Log("FlagCancel");
                XbuttonFlag = false;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "SlowArea")
        {
            Debug.Log("OutSlowArea");
            if (slow && XbuttonFlag)
                data.fallspeed = data.fallspeed * 2;

            slow = false;
            XbuttonFlag = false;
        }
    }
}
