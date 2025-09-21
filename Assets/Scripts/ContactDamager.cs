using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamager : MonoBehaviour
{
    [SerializeField] private float damage;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        
        Life life = other.gameObject.GetComponent<Life>();

        if (life != null)
        {
            life.Damage(damage);
        }
    }
}
