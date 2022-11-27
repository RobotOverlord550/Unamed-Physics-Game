using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CubePlacement : MonoBehaviour
{
    [SerializeField] CubeInformation cubeInformation;
    [SerializeField] GameObject cubeExample;

    private PlayerControls playerControls;

    Vector3 CenterOfCamera = new Vector3(0.5f, 0.5f, 0);

    /// <summary>
    /// attatches a new cube to the cube specified using the normal vector of the surface of the cube the new cube will lie on
    /// </summary>
    /// <param name="normal"></param>
    /// <param name="cube"></param>
    void attatchNewcube(Vector3 normal, GameObject cube)
    {
        CubeBehavior cubeBehavior = cube.GetComponent<CubeBehavior>();
        Transform cubeTransform = cube.gameObject.transform;
        GameObject newCube = Instantiate(cubeExample, cubeTransform.position + normal * cubeInformation.cubeScale, cubeTransform.rotation) as GameObject;

        cubeBehavior.cubeConnect(newCube);
    }

    /// <summary>
    /// checks to see if the ray given hits a cube
    /// </summary>
    /// <param name="ray"></param>
    /// <param name="hit"></param>
    /// <returns></returns>
    bool checkIfHitCube(Ray ray, out RaycastHit hit)
    {
        if(Physics.Raycast(ray, out hit) && hit.collider.transform.gameObject.TryGetComponent<CubeBehavior>(out CubeBehavior x))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void DoCubeBreak(InputAction.CallbackContext obj)
    {
        Ray pointer = Camera.main.ViewportPointToRay(CenterOfCamera);
        RaycastHit hit;
        bool hitCube = checkIfHitCube(pointer, out hit);

        if (hitCube)
        {
            GameObject cube = hit.collider.gameObject;

            cube.GetComponent<CubeBehavior>().cubeDestroy();
        }

    }

    void DoCubePlace(InputAction.CallbackContext obj)
    {
        Ray pointer = Camera.main.ViewportPointToRay(CenterOfCamera);
        RaycastHit hit;
        bool hitCube = checkIfHitCube(pointer, out hit);

        if (hitCube)
        {
            GameObject cube = hit.collider.gameObject;

            attatchNewcube(hit.normal, cube);
        }
    }

    private void Awake()
    {
        playerControls = GetComponent<PlayerControlsManager>().playerControls;
    }

    private void OnEnable()
    {
        playerControls.Player.PlaceBlock.performed += DoCubePlace;
        playerControls.Player.BreakBlock.performed += DoCubeBreak;
    }
}
