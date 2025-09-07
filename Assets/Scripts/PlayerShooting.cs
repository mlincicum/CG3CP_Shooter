using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private Transform shootPoint;

    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            Instantiate(projectile, shootPoint.position, shootPoint.rotation);
        }
    }
}
