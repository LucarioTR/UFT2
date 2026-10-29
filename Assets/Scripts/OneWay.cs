// Nom: [Lucas Torres] - Data: [28/10/2026]
using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    private Collider platformCollider;

    void Start()
    {
        platformCollider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Si el jugador ve des de sota (posició Y menor que la plataforma), ignora la col·lisió
        if (collision.transform.position.y < transform.position.y)
        {
            Physics.IgnoreCollision(collision.collider, platformCollider, true);
        }
    }
}