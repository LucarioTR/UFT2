// Nom: [Lucas Torres] - Data: [28/10/2026]
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class JumpingEnemy : MonoBehaviour
{
    public float jumpForce = 5f;
    public float jumpInterval = 3f;
    private Rigidbody rb;
    private float timer = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= jumpInterval)
        {
            timer = 0f;
            float randomX = Random.Range(-2f, 2f);
            float randomZ = Random.Range(-2f, 2f);
            
            rb.AddForce(new Vector3(randomX, jumpForce, randomZ), ForceMode.Impulse);
        }
    }
}