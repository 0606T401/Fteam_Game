using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceletion : MonoBehaviour
{
    private HeadPoint head;
    private FeetPoint feet;
    private ArmPoint arm;
    public Data data;
    public float acceleration = 5f;
    // Start is called before the first frame update
    void Start()
    {
        head = GameObject.Find("HeadPoint").GetComponent<HeadPoint>();
        feet = GameObject.Find("FeetPoint").GetComponent<FeetPoint>();
        arm = GameObject.Find("ArmPoint").GetComponent<ArmPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if(arm.PassArm||feet.PassFeet||head.PassHead)
        {
            Debug.Log("Pass");
            data.FallSpeed += acceleration;
            arm.PassArm = false;
            feet.PassFeet = false;
            head.PassHead = false;
        }
    }
}