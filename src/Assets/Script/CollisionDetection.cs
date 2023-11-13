using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] GameObject Player;
    public Data data;
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
            data.Hit = true;
            data.fallspeed = 0f;
        }

    }
}
