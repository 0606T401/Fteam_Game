using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalFall : MonoBehaviour
{
    public float playerDistance = 300;
    private StartTimer timer;
    public Data data;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<StartTimer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer.CountDownTime <= 0)
        {
            if (playerDistance > 0)
            {
                transform.position += Vector3.down * data.fallspeed * Time.deltaTime;
                playerDistance -= data.fallspeed * Time.deltaTime;
            }
        }
    }
}