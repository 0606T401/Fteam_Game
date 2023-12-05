using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartParticle : MonoBehaviour
{
    // Start is called before the first frame update

    //�ϐ��̒�`
    [SerializeField] private ParticleSystem particle;

    void Start()
    {
        //Particle�V�X�e���̎擾�i�q�I�u�W�F�N�g����j
        particle = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�Փ˂����������ꍇ�Ɏ��s�����
    void OnTriggerEnter (Collider collision)
    {
        //�ՓˑΏۂ̃^�O��"ParticlePoint"�̏ꍇ��particle��Play����
        if (collision.gameObject.tag == "ParticlePoint")
        {
            particle.Play();
        }
    }
}