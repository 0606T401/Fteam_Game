using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceletion : MonoBehaviour
{
    public ArmPoint arm;
    public FeetPoint feet;
    public HeadPoint head;

    public float acceleration = 5f;
    public Data data;

    public AudioClip Pass;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(arm.PassArm&&feet.PassFeet&&head.PassHead)
        {
            Debug.Log("Pass");

            data.fallspeed += acceleration;

            arm.PassArm = false;
            feet.PassFeet = false;
            head.PassHead = false;
            audioSource.PlayOneShot(Pass);
        }
    }
}