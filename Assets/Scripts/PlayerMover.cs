using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float sidewaysSpeed = 5f;

    [Header("Stats")]
    public float strength = 5f;   // Cu�nto empuja el C4
    public float energy = 10f;    // Cu�nta "vida" le queda

    private bool isDead = false;

    void Update()
    {
        if (isDead) return;

        // Movimiento hacia adelante constante
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // Movimiento lateral con teclas A/D o flechas
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * sidewaysSpeed * Time.deltaTime);

        // Si la energ�a se agot�, mor�s
        if (energy <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        isDead = true;
        Destroy(gameObject); // O animaci�n, efecto, etc.
    }
}
