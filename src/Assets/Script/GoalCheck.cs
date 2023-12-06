using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GoalCheck : MonoBehaviour
{
    public ArmPoint arm;
    public FeetPoint feet;
    public HeadPoint head;
    public bool goal=false;
    public Data data;
    public GameObject ClearPanel;
    public GameObject GameOver;

    public GameObject PauseFirstButton;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (arm.PassArm && feet.PassFeet && head.PassHead)
        {
            if (!goal)
            {
                goal = true;
                Debug.Log("Goal ok");
                data.fallspeed = 0f;
                if (GameOver.activeSelf == false)
                {
                    EventSystem.current.SetSelectedGameObject(null);
                    EventSystem.current.SetSelectedGameObject(PauseFirstButton);
                    ClearPanel.SetActive(true);
                }
            }
        }

        
    }
}
