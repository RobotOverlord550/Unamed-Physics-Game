using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private PlayerControls playerControls;
    private Vector2 PlayerMovementInput, PlayerCameraInput;
    private float xRot;    
    private bool jumpButtonPressed;

    [SerializeField] float cameraSensitivity;
    [SerializeField] float jumpForce;
    [SerializeField] float movementForce;
    [SerializeField] float movementVelocity;

    [SerializeField] Rigidbody rigidBody;
    [SerializeField] Transform transform;
    [SerializeField] Transform PlayerCamera;
    [SerializeField] Collider collider;

    /// <summary>
    /// Checks if the player is grounded
    /// </summary>
    /// <returns></returns>
    private bool isGrounded()
    {
        return Physics.Raycast(collider.bounds.center, Vector3.down, collider.bounds.extents.y + .1f);
    }

    /// <summary>
    /// Updates players movement based on current player input
    /// </summary>
    private void MovePlayer()
    {
        Vector3 moveVector = transform.TransformDirection(PlayerMovementInput.x, 0 , PlayerMovementInput.y) * movementVelocity;
        rigidBody.velocity = (new Vector3(moveVector.x, rigidBody.velocity.y, moveVector.z));
    }

    private void DoJump(InputAction.CallbackContext obj)
    {
        if(isGrounded())
        {
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void DoCrouch(InputAction.CallbackContext obj)
    {
    }

    /// <summary>
    /// Update players camera position
    /// </summary>
    private void MoveCamera()
    {
        xRot -= PlayerCameraInput.y * cameraSensitivity;

        transform.Rotate(0f, PlayerCameraInput.x * cameraSensitivity, 0f);
        PlayerCamera.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
    }

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;

        playerControls = GetComponent<PlayerControlsManager>().playerControls;
    }

    private void OnEnable()
    {
        playerControls.Walking.Jump.started += DoJump;
        playerControls.Walking.Crouch.started += DoCrouch;
    }

    void Update()
    {
        PlayerMovementInput = playerControls.Walking.Move.ReadValue<Vector2>();

        PlayerCameraInput = playerControls.Walking.Look.ReadValue<Vector2>();

        MovePlayer();
        MoveCamera();
    }
}
