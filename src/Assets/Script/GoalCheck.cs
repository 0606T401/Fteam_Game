using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;
using UnityEngine.UI;

public class GoalCheck : MonoBehaviour
{
    public ArmPoint arm;
    public FeetPoint feet;
    public HeadPoint head;
    public bool goal=false;
    public Data data;
    public GameObject ClearPanel;
    public GameObject ClearMovie;
    public GameObject GameOver;
    public VideoPlayer ClearMovieSetting;
    private float time = 0f;
    [SerializeField] private float ResultTime = 7f;
    public AudioClip GoalBGM;

    public GameObject PauseFirstButton;
    public AudioClip GoalSound;
    AudioSource audioSource;

    [SerializeField] public ParticleSystem sideParticle;
    [SerializeField] public ParticleSystem bottomParticle;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (arm.PassArm && feet.PassFeet && head.PassHead)
        {
            time += Time.deltaTime;
            

            if (!goal)
            {
                goal = true;
                audioSource.PlayOneShot(GoalSound);
                Debug.Log("Goal ok");
                data.fallspeed = 0f;

                audioSource.PlayOneShot(GoalBGM);
                ClearMovie.SetActive(true);
                ClearMovieSetting.Play();
            }

            if (time > ResultTime)
            {
                Debug.Log("clear!!");
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(PauseFirstButton);
                ClearPanel.SetActive(true);
            }
        }
    }
}
