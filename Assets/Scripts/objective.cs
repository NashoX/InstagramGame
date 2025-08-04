using UnityEngine;

public class C4Object : MonoBehaviour
{
    public float requiredForce = 10f; // Fuerza mínima para mover el C4
    public float movementMultiplier = 1f; // Cuánto se mueve según la fuerza
    public float energyDrainRate = 1f; // Cuánta energía pierde el clon por segundo

    private Vector3 pushDirection = Vector3.forward;
    private float totalForceApplied = 0f;

    void FixedUpdate()
    {
        if (totalForceApplied > 0)
        {
            float movementSpeed = (totalForceApplied / requiredForce) * movementMultiplier;
            transform.Translate(pushDirection * movementSpeed * Time.fixedDeltaTime);
            totalForceApplied = 0f; // Reset para el siguiente frame
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        PlayerMover player = collision.collider.GetComponent<PlayerMover>();
        if (player != null)
        {
            player.energy -= energyDrainRate * Time.deltaTime;
            totalForceApplied += player.strength;
        }
    }
}
