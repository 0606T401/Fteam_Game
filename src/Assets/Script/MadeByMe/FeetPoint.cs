using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetPoint : MonoBehaviour
{
    public bool PassFeet;
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
        if (col.gameObject.name == "Feet")
        {
            PassFeet = true;
            Debug.Log("feet ok");
        }
    }
}
