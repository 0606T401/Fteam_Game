using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRange : MonoBehaviour
{
    private Vector3 initialPos;
    public float maxminPosX = 7f;
    public float maxminPosz = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;

        currentPos.x = Mathf.Clamp(currentPos.x, -maxminPosX, maxminPosX);
        currentPos.z = Mathf.Clamp(currentPos.z, -maxminPosz, maxminPosz);

        transform.position = currentPos;
    }
}
