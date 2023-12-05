using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartParticle : MonoBehaviour
{
    // Start is called before the first frame update

    //変数の定義
    [SerializeField] private ParticleSystem particle;

    void Start()
    {
        //Particleシステムの取得（子オブジェクトから）
        particle = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //衝突が発生した場合に実行される
    void OnTriggerEnter (Collider collision)
    {
        //衝突対象のタグが"ParticlePoint"の場合にparticleをPlayする
        if (collision.gameObject.tag == "ParticlePoint")
        {
            particle.Play();
        }
    }
}