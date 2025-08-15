using UnityEngine;
using Cinemachine;

public class CamaraChanger : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera[] allCameras;

    private CinemachineVirtualCamera currentCamera;
    public void ChangeTo(CinemachineVirtualCamera targetCamera)
    {
        if (currentCamera == targetCamera) return;
        foreach (var cam in allCameras)
        {
            cam.Priority = (cam == targetCamera) ? 10 : 0;
        }
        currentCamera = targetCamera;

    }
}
