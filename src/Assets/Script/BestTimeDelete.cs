using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestTimeDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Delete BestTime");
    }
}
