using System;
using UnityEngine;

public class VelocityAnimator : MonoBehaviour
{
    private static readonly int Velocity = Animator.StringToHash("Velocity");
    private Rigidbody rb;
    private Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
        animator.SetFloat(Velocity, rb.velocity.magnitude);
    }
}
