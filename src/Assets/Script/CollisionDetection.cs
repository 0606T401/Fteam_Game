using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] GameObject Player;
    public Data data;

    public GameObject GameOver;

    public GameObject pouseFirstbutton;
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
        if (col.gameObject.name == "chara")
        {
            Debug.Log("Hit");
            data.fallspeed = 0f;

            EventSystem.current.SetSelectedGameObject(null);

            EventSystem.current.SetSelectedGameObject(pouseFirstbutton);

            GameOver.SetActive(true);
        }

    }
}
