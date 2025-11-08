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
    [SerializeField] private AudioSource shootSound;

    [SerializeField] private ParticleSystem muzzleFlash;

    public int bulletsAmount;

    public void OnFire(InputValue value)
    {
        if (value.isPressed && bulletsAmount > 0 && Time.timeScale > 0)
        {
            bulletsAmount--;

            Instantiate(projectile, shootPoint.position, shootPoint.rotation);
            muzzleFlash.Play();
            shootSound.Play();
        }
    }
}
