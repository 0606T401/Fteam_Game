using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockWay : MonoBehaviour
{
    public float blockDistance = 100;
    public float MoveSeconds = 5;
    //public float MoveSpeed = 20;

    float MoveSpeed;
    float BlockDistance;

    private StartTimer timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<StartTimer>();
        BlockDistance = blockDistance;
        MoveSpeed = blockDistance / MoveSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.CountDownTime <= 0)
        {
            if (blockDistance > 0 && BlockDistance >= 0)
            {
                transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
                BlockDistance -= MoveSpeed * Time.deltaTime;
            }

            if (blockDistance < 0 && BlockDistance <= 0)
            {
                transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
                BlockDistance -= MoveSpeed * Time.deltaTime;
            }
        }
    }
}
