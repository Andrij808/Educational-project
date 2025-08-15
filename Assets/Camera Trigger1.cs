using UnityEngine;
using Cinemachine;

public class CameraTrigger1 : MonoBehaviour
{
    private const string PlayerTag = "Player";

    [SerializeField] private CinemachineVirtualCamera thisCamera;
    [SerializeField] private CamaraChanger cameraChanger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PlayerTag))
        {
            cameraChanger.ChangeTo(thisCamera);
        }
        
    }
}