using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalFlag : MonoBehaviour
{
    bool GoalHead;
    bool GoalFeet;
    bool GoalArm;
    public bool Goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GoalArm&&GoalFeet&&GoalHead)
        {
            if(!Goal)
            {
                Goal = true;
                Debug.Log("Goal ok");
            }
            
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Feet")
        {
            GoalFeet = true;
            Debug.Log("feet ok");
        }
        if (col.gameObject.name == "Arm")
        {
            GoalArm = true;
            Debug.Log("Arm ok");
        }
        if (col.gameObject.name == "Head")
        {
            GoalHead = true;
            Debug.Log("Head ok");
        }
    }

}
