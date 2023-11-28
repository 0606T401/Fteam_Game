using Cinemachine;
using UnityEngine;

public class PathTest : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera _virtualCamera;
    [SerializeField]
    private float _position = 0;

    private CinemachineTrackedDolly _dolly;
    

    void Start()
    {
        // Virtual Camera�ɑ΂���GetCinemachineComponent��CinemachineTrackedDolly���擾����
        // GetComponent�ł͂Ȃ�GetCinemachineComponent�Ȃ̂Œ���
        _dolly = _virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    void Update()
    {
        _position += Time.deltaTime*2;
        // �p�X�̈ʒu���X�V����
        // ������ėǂ��̂��s���ɂȂ�ϐ��������ǂ����OK
        _dolly.m_PathPosition= _position;
    }
}