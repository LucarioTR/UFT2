// Nom: [Lucas Torres] - Data: [28/10/2026]
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CoinWithSound : MonoBehaviour
{
    private AudioSource audioSource;
    private bool collected = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !collected)
        {
            collected = true;
            audioSource.Play();
            
            // Ocultar la moneda i destruir-la després que soni l'àudio
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject, audioSource.clip.length);
        }
    }
}