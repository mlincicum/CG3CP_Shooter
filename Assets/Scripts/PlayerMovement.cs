using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed, rotationSpeed;
    private Vector2 movementValue;
    private float lookValue;
    
    private Rigidbody rb;

    void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
    }

    private void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
    }

    void Update()
    {
        // Apply movement
        rb.AddRelativeForce(
            movementValue.x * Time.deltaTime,
            0,
            movementValue.y * Time.deltaTime
        );
        
        // Apply rotation
        rb.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);
    }
}
