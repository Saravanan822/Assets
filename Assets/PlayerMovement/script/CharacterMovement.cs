using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    CharacterController controller;
    Animator animator;

    public Vector3 moveDelta;
    public float moveSpeed;

    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveDelta = new();
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HandlePlayerMovement();
        HandlePlayerRotation();
    }

    void HandlePlayerMovement()
    {
        moveDelta.x = MovementHandler.MovementVector.x;
        moveDelta.z = MovementHandler.MovementVector.y;

        moveDelta = transform.TransformDirection(moveDelta);
        controller.Move(moveDelta * moveSpeed);

        if(moveDelta == Vector3.zero) animator.enabled = false;
        else animator.enabled = true;   
    }
    void HandlePlayerRotation()
    {
        transform.Rotate(Vector3.up,(RotationHandler.RotationVector.x*rotateSpeed),Space.Self);
    }
}
