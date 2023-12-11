using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartParticle : MonoBehaviour
{
    // Start is called before the first frame update

    //ïœêîÇÃíËã`
    public ParticleSystem particle;

    List<GameObject> colList = new List<GameObject>();

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int colListCnt1 = 0;
        foreach (GameObject go in colList)
        {
            if (go.gameObject.name == "FeetPoint")
            {
                colListCnt1+=1;
            }

            if (go.gameObject.name == "ArmPoint")
            {
                colListCnt1+=1;
            }

            if (go.gameObject.name == "HeadPoint")
            {
                colListCnt1+=1;
            }

            if (colListCnt1 > 2)
            {
                particle.Play();
            }
        }
    }

    //è’ìÀÇ™î≠ê∂ÇµÇΩèÍçáÇ…é¿çsÇ≥ÇÍÇÈ
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "FeetPoint")
        {
            colList.Add(collision.gameObject);
        }

        if (collision.gameObject.name == "ArmPoint")
        {
            colList.Add(collision.gameObject);
        }

        if (collision.gameObject.name == "HeadPoint")
        {
            colList.Add(collision.gameObject);
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "FeetPoint")
        {
            colList.Remove(collision.gameObject);
        }

        if (collision.gameObject.name == "ArmPoint")
        {
            colList.Remove(collision.gameObject);
        }

        if (collision.gameObject.name == "HeadPoint")
        {
            colList.Remove(collision.gameObject);
        }
    }
}