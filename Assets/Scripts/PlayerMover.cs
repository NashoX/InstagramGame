using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float sidewaysSpeed = 5f;

    [Header("Stats")]
    public float strength = 5f;   // Cuánto empuja el C4
    public float energy = 10f;    // Cuánta "vida" le queda

    private bool isDead = false;

    void Update()
    {
        if (isDead) return;

        // Movimiento hacia adelante constante
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // Movimiento lateral con teclas A/D o flechas
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * sidewaysSpeed * Time.deltaTime);

        // Si la energía se agotó, morís
        if (energy <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        isDead = true;
        Destroy(gameObject); // O animación, efecto, etc.
    }
}
