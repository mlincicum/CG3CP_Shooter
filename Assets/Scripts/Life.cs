using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] private float amount;

    public void damage(float damage)
    {
        amount -= damage;
        if (amount <= 0) Destroy(gameObject);
    }
}
