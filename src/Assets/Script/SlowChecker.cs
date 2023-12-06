using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowChecker : MonoBehaviour
{
    [SerializeField] GameObject frame;
    [SerializeField] Material white;
    [SerializeField] Material orange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.name == "chara")
        {
            frame.GetComponent<Renderer>().material = orange;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "chara")
        {
            frame.GetComponent<Renderer>().material = white;
        }
    }
}
