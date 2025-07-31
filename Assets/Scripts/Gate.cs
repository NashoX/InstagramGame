using UnityEngine;

public class GateSpawner : MonoBehaviour
{
    public int amountToSpawn = 5; // Total que querés que haya al final (incluyendo el original)
    [SerializeField] private float separation = 1.5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Mover al original a la derecha
            other.transform.position += Vector3.right * separation;

            // Instanciar clones: cantidad total menos el original
            for (int i = 1; i < amountToSpawn; i++)
            {
                // Cada clon va más a la izquierda
                Vector3 offset = Vector3.left * i * separation;
                Vector3 spawnPos = other.transform.position + offset;
                spawnPos.y = other.transform.position.y;

                Instantiate(other.gameObject, spawnPos, other.transform.rotation);
            }

            Destroy(gameObject); // La puerta se destruye después de usarse
        }
    }
}
