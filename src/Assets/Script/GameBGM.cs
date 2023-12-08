using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBGM : MonoBehaviour
{
    public Data data;
    public GoalCheck goal;
    public AudioClip BGM;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(data.Hit||goal.goal)
        {
            audioSource.Pause();
        }
    }
}
