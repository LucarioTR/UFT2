
using UnityEngine;

public class PlayerMover3D_Inertia : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 targetVel = new Vector3(moveHorizontal, 0f, moveVertical) * speed;
        targetVel.y = rb.linearVelocity.y; // Mantenir la caiguda o física vertical

        rb.linearVelocity = Vector3.Lerp(rb.linearVelocity, targetVel, 0.1f);
    }
}