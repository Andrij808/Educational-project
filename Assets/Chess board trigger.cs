using Unity.VisualScripting;
using UnityEngine;

public class Cheassboardtrigger : MonoBehaviour
{
    public GameObject cheassboard;
    public float spawnDistance = 1.5f;
    private bool HasSpawned = false;
    private void OnTriggerEnter(Collider other)
    {
        if (HasSpawned) return;

        if (other.CompareTag("Player"))
        {
            Vector3 spawnPos = other.transform.position + other.transform.forward * spawnDistance;
            Quaternion spawnRot = Quaternion.identity;

            Instantiate(cheassboard, spawnPos, spawnRot);
            Debug.Log("Cheassboard Triggered" + other.name);
            HasSpawned = true;
        }
       
    }
}
