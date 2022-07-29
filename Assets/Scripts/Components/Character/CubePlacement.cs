using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlacement : MonoBehaviour
{
    [SerializeField] GameObject cubeExample;

    Vector3 CenterOfCamera = new Vector3(0.5f, 0.5f, 0);

    Inventory[] inventory;

    /// <summary>
    /// Attatches new cube to cube the cross hair is pointing at if the cross hair is pointing at a cube
    /// </summary>
    void updateCubeAttatching()
    {
        /// <summary>
        /// attatches a new cube to the cube specified using the normal vector of the surface of the cube the new cube will lie on
        /// </summary>
        /// <param name="normal"></param>
        /// <param name="cube"></param>
        void attatchNewcube(Vector3 normal, GameObject cube)
        {
            CubeBehavior cubeBehavior = cube.GetComponent<CubeBehavior>();
            Transform cubeTransform = cube.gameObject.transform;
            GameObject newCube = Instantiate(cubeExample, cubeTransform.position + normal * .5f, cubeTransform.rotation) as GameObject;

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

        Ray pointer = Camera.main.ViewportPointToRay(CenterOfCamera);
        RaycastHit hit;
        bool hitCube = checkIfHitCube(pointer, out hit);
        GameObject cube;

        if (Input.GetKeyDown(KeyCode.Mouse0) && hitCube)
        {
            cube = hit.collider.gameObject;

            cube.GetComponent<CubeBehavior>().cubeDestroy();
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1) && hitCube)
        {
            cube = hit.collider.gameObject;

            attatchNewcube(hit.normal, cube);
        }
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        updateCubeAttatching();
    }
}
