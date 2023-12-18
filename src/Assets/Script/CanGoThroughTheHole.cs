using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanGoThroughTheHole : MonoBehaviour
{
    [SerializeField] GameObject frame;
    [SerializeField] Material Green;
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
            frame.GetComponent<Renderer>().material = Green;
        }
    }
}
