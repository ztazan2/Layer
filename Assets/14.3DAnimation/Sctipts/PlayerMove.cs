using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController), typeof(Animator))]
public class PlayerMove : MonoBehaviour
{
    private CharacterController charCtrl;
    private Animator animator;

    public float walkSpeed;
    public float runSpeed;
    private float currentSpeed;

    private void Awake()
    {
        charCtrl = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 inputValue = Vector3.zero;
        inputValue.x = Input.GetAxis("Horizontal");
        inputValue.z = Input.GetAxis("Vertical");

        inputValue = Vector3.ClampMagnitude(inputValue, 1);

        // Run value (e.g., Shift key) for running state
        float runValue = Input.GetAxis("Fire3");

        // Calculate the current speed based on walking or running
        currentSpeed = (inputValue.magnitude * walkSpeed) + (runValue * (runSpeed - walkSpeed));

        Vector3 inputMoveDir = inputValue * currentSpeed;
        Vector3 actualMoveDir = transform.TransformDirection(inputMoveDir);

        // Move the character
        charCtrl.Move(actualMoveDir * Time.deltaTime);

        // Update animator with speed and direction for animation blending
        animator.SetFloat("Speed", inputValue.magnitude + runValue);
        animator.SetFloat("Xdir", inputValue.x);
        animator.SetFloat("Ydir", inputValue.z);
    }
}
