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
        _dolly = _virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    void Update()
    {
        _position += Time.deltaTime*2;
        _dolly.m_PathPosition= _position;
    }
}