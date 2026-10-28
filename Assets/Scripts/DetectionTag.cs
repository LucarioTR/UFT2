// Nom: [El teu nom] - Data: [Data]
using UnityEngine;

public class CoinDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Versió A (Menys eficient): other.gameObject.name == "Player"
        
        // Versió B (Més eficient i recomanada):
        if (other.CompareTag("Player"))
        {
            // Per què és millor CompareTag? 
            // 1. És molt més ràpid a nivell de rendiment intern a Unity.
            // 2. Evita errors de comparar directament cadenes de text (strings) i estalvia generació d'escombraries a la memòria (garbage collection).
            Destroy(gameObject);
        }
    }
}