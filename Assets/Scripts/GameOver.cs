// Nom: [El teu nom] - Data: [Data]
using UnityEngine;

public class GameManagerVides : MonoBehaviour
{
    public static GameManagerVides Instance;
    public int lives = 3;
    public Vector3 respawnPoint;
    public Transform playerTransform;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void LoseLife()
    {
        lives--;
        Debug.Log($"Vides restants: {lives}");

        if (lives > 0)
        {
            RespawnPlayer();
        }
        else
        {
            GameOver();
        }
    }

    void RespawnPlayer()
    {
        if (playerTransform != null)
        {
            // Desactivar temporalment la física per evitar rebots estranys al teleportar
            Rigidbody rb = playerTransform.GetComponent<Rigidbody>();
            if (rb != null) rb.linearVelocity = Vector3.zero;

            playerTransform.position = respawnPoint;
            Debug.Log("Jugador respawnejat a l'inici.");
        }
    }

    void GameOver()
    {
        Debug.Log("GAME OVER");
        // Aquí pots afegir la lògica per mostrar la pantalla de Game Over
    }
}