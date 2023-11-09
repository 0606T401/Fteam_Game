using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceletion : MonoBehaviour
{
    private HeadPoint head;
    private FeetPoint feet;
    private ArmPoint arm;
    private JustHeadPoint justHead;
    private JustArmPoint justArm;
    private JustFeetPoint justFeet;

    public float acceleration = 2.5f;
    public float justAcceleration = 5f;
    public Data data;
    // Start is called before the first frame update
    void Start()
    {
        head = GameObject.Find("HeadPoint").GetComponent<HeadPoint>();
        feet = GameObject.Find("FeetPoint").GetComponent<FeetPoint>();
        arm = GameObject.Find("ArmPoint").GetComponent<ArmPoint>();
        justHead = GameObject.Find("JustHeadPoint").GetComponent<JustHeadPoint>();
        justFeet = GameObject.Find("JustFeetPoint").GetComponent<JustFeetPoint>();
        justArm = GameObject.Find("JustArmPoint").GetComponent<JustArmPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if(justArm.JustPassArm&&justFeet.JustPassFeet&&justHead.JustPassHead)
        {
            Debug.Log("JustPass");

            data.fallspeed += justAcceleration;

            justArm.JustPassArm = false;
            justFeet.JustPassFeet = false;
            justHead.JustPassHead = false;
        }

        if(arm.PassArm&&feet.PassFeet&&head.PassHead)
        {
            Debug.Log("Pass");

            data.fallspeed += acceleration;

            arm.PassArm = false;
            feet.PassFeet = false;
            head.PassHead = false;
        }
    }
}