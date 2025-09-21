using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight : MonoBehaviour
{
    [SerializeField] private float distance;
    [SerializeField] private float angle;
    [SerializeField] private LayerMask obstaclesLayer;
    [SerializeField] private LayerMask objectsLayer;

    public Collider detectedObject;

    void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, distance, objectsLayer);

        detectedObject = null;
        for (int i = 0; i < colliders.Length; i++)
        {
            Collider collider = colliders[i];
            
            Vector3 directionToCollider = Vector3.Normalize(collider.bounds.center - transform.position);
            Vector3 directionToController = Vector3.Normalize(collider.bounds.center - transform.position);
            
            float angleToCollider = Vector3.Angle(transform.forward,  directionToCollider);
            if (angleToCollider < angle)
            {
                if (!Physics.Linecast(transform.position, collider.bounds.center, out RaycastHit hit, obstaclesLayer))
                {
                    Debug.DrawLine(transform.position,  collider.bounds.center, Color.green);
                    detectedObject = collider;
                    break;
                }
                else
                {
                    Debug.DrawLine(transform.position, hit.point, Color.red);
                }
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distance);

        Vector3 rightDirection = Quaternion.Euler(0, angle, 0) * transform.forward;
        Gizmos.DrawRay(transform.position, rightDirection * distance);
        
        Vector3 leftDirection = Quaternion.Euler(0, -angle, 0) * transform.forward;
        Gizmos.DrawRay(transform.position, leftDirection * distance);
    }
}
