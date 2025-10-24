using UnityEngine;

public class ExplosionOnDeath : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;

    void Start()
    {
        Life life = GetComponent<Life>();
        life.onDeath.AddListener(SpawnExplosion);
    }

    void SpawnExplosion()
    {
        Instantiate(
            explosionPrefab,
            transform.position,
            transform.rotation
        );
    }
}
