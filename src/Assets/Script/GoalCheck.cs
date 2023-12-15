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
    public GameObject PauseFirstButton;
    
    public AudioSource GoalBGM;
    public AudioSource GoalSound;
    [SerializeField] private AudioClip goalBGM;
    [SerializeField] private AudioClip goalSound;
    

    [SerializeField] public ParticleSystem sideParticle;
    [SerializeField] public ParticleSystem bottomParticle;
    // Start is called before the first frame update
    void Start()
    {
        
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
                goalSE();
                Debug.Log("Goal ok");
                data.fallspeed = 0f;

                goalMusic();
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

    void goalSE()
    {
        GoalSound.PlayOneShot(goalSound);
    }
    void goalMusic()
    {
        GoalBGM.PlayOneShot(goalBGM);
    }
}
