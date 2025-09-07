using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private Transform shootPoint;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Instantiate(projectile, shootPoint.position, shootPoint.rotation);
        }   
    }
}
