using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public bool Hit;
    bool sound = false;
    public float fallspeed = 15f;

    public AudioClip GameOver;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Hit && !sound) 
        {
            audioSource.PlayOneShot(GameOver);
            sound = true;
        }
    }
}
