using UnityEngine;

public class Chessrookcollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Chess Rook Collider Triggered: " + collision.gameObject.name);
    }
}

