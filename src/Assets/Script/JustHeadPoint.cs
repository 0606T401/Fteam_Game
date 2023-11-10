using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustHeadPoint : MonoBehaviour
{
    public bool JustPassHead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Head")
        {
            JustPassHead = true;
            Debug.Log("head just");
        }
    }
}
