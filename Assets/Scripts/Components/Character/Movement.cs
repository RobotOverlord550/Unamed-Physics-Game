using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 PlayerMovementInput;
    private Vector2 PlayerMouseInput;
    private float xRot;

    [SerializeField] float cameraSensitivity;
    [SerializeField] float jumpForce;
    [SerializeField] float movementForce;
    [SerializeField] float movementVelocity;
    [SerializeField] bool noClip = false;

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
        // moving
        Vector3 moveVector = transform.TransformDirection(PlayerMovementInput) * movementVelocity;
        rigidBody.velocity = new Vector3(moveVector.x, rigidBody.velocity.y, moveVector.z);

        // jumping
        if (noClip)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rigidBody.velocity = new Vector3(rigidBody.velocity.x, movementVelocity, rigidBody.velocity.z);
            }
            else if(Input.GetKey(KeyCode.LeftShift))
            {
                rigidBody.velocity = new Vector3(rigidBody.velocity.x, -movementVelocity, rigidBody.velocity.z);
            }
            else
            {
                rigidBody.velocity = new Vector3(rigidBody.velocity.x, 0, rigidBody.velocity.z);
            }
        }
        else if(Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

    /// <summary>
    /// Update players camera position
    /// </summary>
    private void MoveCamera()
    {
        xRot -= PlayerMouseInput.y * cameraSensitivity;

        transform.Rotate(0f, PlayerMouseInput.x * cameraSensitivity, 0f);
        PlayerCamera.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
    }

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {

    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        PlayerMouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        if (Input.GetKeyDown(KeyCode.F))
        {
            noClip = !noClip;
            rigidBody.useGravity = !rigidBody.useGravity;
        }

        MovePlayer();
        MoveCamera();
    }
}
