using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustArmPoint : MonoBehaviour
{
    public bool JustPassArm;
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
        if (col.gameObject.name == "Arm")
        {
            JustPassArm = true;
            Debug.Log("arm just");
        }
    }
}
