using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadPoint : MonoBehaviour
{
    public bool PassHead;
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
            PassHead = true;
            Debug.Log("head ok");
        }
    }
}