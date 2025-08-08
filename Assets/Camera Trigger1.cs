using UnityEngine;
using Cinemachine;

public class CameraTrigger1 : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera virtualCamera;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           ActivateThisCamera();
        }
    }
    void ActivateThisCamera()
    {
        CinemachineVirtualCamera[] allCams = FindObjectsOfType<CinemachineVirtualCamera>();
        foreach (var cam in allCams)
        {
            cam.Priority = (cam == virtualCamera) ? 10 : 0;
        }
    }
}
