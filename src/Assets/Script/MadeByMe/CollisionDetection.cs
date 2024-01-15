using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] GameObject Player;
    public Data data;

    public GameObject GameOver; 
    public GameObject ClearPanel;

    public GameObject pauseFirstbutton;


    public GoalCheck goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(!goal.goal)
        {
            if (col.gameObject.name == "chara")
            {
                Debug.Log("Hit");
                data.Hit = true;
                data.fallspeed = 0f;
                if (ClearPanel.activeSelf == false)
                {
                    EventSystem.current.SetSelectedGameObject(null);


                    EventSystem.current.SetSelectedGameObject(pauseFirstbutton);

                    GameOver.SetActive(true);
                }
            }
        }
        

    }
}