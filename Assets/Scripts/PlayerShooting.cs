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

    [SerializeField] private ParticleSystem muzzleFlash;

    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            Instantiate(projectile, shootPoint.position, shootPoint.rotation);
            muzzleFlash.Play();
        }
    }
}
