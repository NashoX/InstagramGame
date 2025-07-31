using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float sidewaysSpeed = 5f;
    private PlayerManager playerManager;
    private void Start()
    {
       // FindAnyObjectByType(typeof(PlayerManager));
        //playerManager.RegisterPlayer(this);
    }
    void Update()
    {
        // Movimiento hacia adelante constante
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // Movimiento lateral con teclas A/D o flechas
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * sidewaysSpeed * Time.deltaTime);
    }
 private void Death()
    {
       // playerManager.UnregisterPlayer(this);
    }
}
