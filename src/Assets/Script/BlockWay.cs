using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockWay : MonoBehaviour
{

    public float blockDistanceX = 100;
    public float blockDistanceY = 100;
    public float blockDistanceZ = 100;
    public float MoveSeconds = 5;
    //public float MoveSpeed = 20;

    float MoveSpeedX;
    float MoveSpeedY;     
    float MoveSpeedZ;
    float BlockDistanceX;
    float BlockDistanceY;
    float BlockDistanceZ;

    private StartTimer timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<StartTimer>();
        BlockDistanceX = blockDistanceX;
        BlockDistanceY = blockDistanceY;
        BlockDistanceZ = blockDistanceZ;
        if (blockDistanceX == 0)
        {
            MoveSpeedX = 0;
        }
        else
        {
            MoveSpeedX = blockDistanceX / MoveSeconds;
        }

        if (blockDistanceY == 0)
        {
            MoveSpeedY = 0;
        }
        else
        {
            MoveSpeedY = blockDistanceY / MoveSeconds;
        }
        
        if(blockDistanceZ == 0) 
        {
            MoveSpeedZ = 0;
        }
        else
        {
            MoveSpeedZ = blockDistanceZ / MoveSeconds;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.CountDownTime <= 0)
        {
            if ((blockDistanceX > 0 && BlockDistanceX >= 0) || (blockDistanceX < 0 && BlockDistanceX <= 0))
            {
                transform.position += Vector3.right * MoveSpeedX * Time.deltaTime;
                BlockDistanceX -= MoveSpeedX * Time.deltaTime;
            }

            if ((blockDistanceY > 0 && BlockDistanceY >= 0) || (blockDistanceY < 0 && BlockDistanceY <= 0))
            {
                transform.position += Vector3.up * MoveSpeedY * Time.deltaTime;
                BlockDistanceY -= MoveSpeedY * Time.deltaTime;
            }

            if ((blockDistanceZ > 0 && BlockDistanceZ >= 0) || (blockDistanceZ < 0 && BlockDistanceZ <= 0))
            {
                transform.position += Vector3.forward * MoveSpeedY * Time.deltaTime;
                BlockDistanceZ -= MoveSpeedZ * Time.deltaTime;
            }




        }

    }
}
