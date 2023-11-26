using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveTest : MonoBehaviour
{
    public StartTimer timer;
    public Timeline_DiskIntroductionCameraDolly dolly;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dolly.SetTime(3000);
        if(timer.CountDownTime>0f)
        {
            dolly.OnControlTimeStart();
            
        }
        else
            dolly.OnControlTimeStop();
    }
}
