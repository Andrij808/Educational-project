using Unity.VisualScripting;
using UnityEngine;

public class ChessBoardTrigger : MonoBehaviour
{
    private const string PlayerTag = "Player";

    [SerializeField] private GameObject chessFigurePrefab;

    [SerializeField] private float spawnDistance = 1.5f;

    private bool hasSpawned = false;
    private void OnTriggerEnter(Collider other)
    {
        if (hasSpawned) return;

        if (other.CompareTag(PlayerTag))
        {
            Vector3 spawnPos = other.transform.position + other.transform.forward * spawnDistance;
            Quaternion spawnRot = chessFigurePrefab.transform.rotation;

            Instantiate(chessFigurePrefab, spawnPos, spawnRot);
            Debug.Log("Chess piece spawned in front of: {other.name}");
            hasSpawned = true;
        }
       
    }
}
