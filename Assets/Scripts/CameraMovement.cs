using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private PlayerMover playermover;

    public void Update()
    {
        // Movimiento hacia adelante constante
        transform.Translate(Vector3.forward * playermover.forwardSpeed * Time.deltaTime);
    }

}

