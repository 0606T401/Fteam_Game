using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartParticle : MonoBehaviour
{
    // Start is called before the first frame update

    //変数の定義
    [SerializeField] private ParticleSystem particle;

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
                colListCnt1++;
            }

            if (go.gameObject.name == "ArmPoint")
            {
                colListCnt1++;
            }

            if (go.gameObject.name == "HeadPoint")
            {
                colListCnt1++;
            }


            if (colListCnt1 >= 3)
            {
                particle.Play();
            }
        }
    }

    //衝突が発生した場合に実行される
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