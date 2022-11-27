using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Script which defines the behavior of a cube game object
/// </summary>
public class CubeBehavior : MonoBehaviour
{
    [SerializeField] CubeInformation cubeInformation;

    GameObject[] cubesNextToThisOne = new GameObject[6];
    protected bool isAnchor = true;

    /// <summary>
    /// Creates new cube system with a provided list of cubes (must be called within the cube behavior component of one of the cubes in the list)
    /// </summary>
    /// <param name="cubes"></param>
    protected virtual void createNewCubeSystem(List<GameObject> cubes)
    {     
        foreach (GameObject cube in cubes)
        {
            cube.GetComponent<CubeBehavior>().isAnchor = false;
        }

        isAnchor = true;

        transform.SetParent(null);

        if (cubes.Count > 1)
        {
            for (int i = 1; i < cubes.Count; i++)
            {
                GameObject cube = cubes[i];

                cube.GetComponent<Transform>().SetParent(transform);
            }
        }

        foreach (GameObject cube in cubes)
        {
            cube.GetComponent<CubeBehavior>().UpdateCubesNextToThisOne();
        }
    }

    /// <summary>
    /// Looks for cubes that a side of this cube is indirectly connected to
    /// </summary>
    /// <param name="side"></param>
    /// <param name="sidesFound"></param>
    /// <returns></returns>
    private List<GameObject> lookForConnectedCubes(int side, ref bool[] sidesFound)
    {
        List<GameObject> connectedCubes = new List<GameObject>();

        if (cubesNextToThisOne[side] != null)
        {
            connectedCubes.Add(cubesNextToThisOne[side]);
            cubesNextToThisOne[side].GetComponent<CubeBehavior>().lookForConnectedCubesHelperMethod(connectedCubes, this.gameObject, ref sidesFound);
        }

        return connectedCubes;
    }

    /// <summary>
    /// Helper method for lookForConnectedCubes
    /// </summary>
    /// <param name="foundCubes"></param>
    /// <param name="startingCube"></param>
    /// <param name="sidesFound"></param>
    private void lookForConnectedCubesHelperMethod(List<GameObject> foundCubes, GameObject startingCube, ref bool[] sidesFound)
    {
        for (int i = 0; i < 6; i++)
        {
            GameObject cubeNextToThisOne = cubesNextToThisOne[i];

            if (cubeNextToThisOne != null && !foundCubes.Contains(cubeNextToThisOne) && cubeNextToThisOne != startingCube)
            {
                for (int x = 0; x < 6; x++)
                {
                    if (cubeNextToThisOne == startingCube.GetComponent<CubeBehavior>().cubesNextToThisOne[x])
                    {
                        sidesFound[x] = true;
                    }
                }

                foundCubes.Add(cubeNextToThisOne);

                cubeNextToThisOne.GetComponent<CubeBehavior>().lookForConnectedCubesHelperMethod(foundCubes, startingCube, ref sidesFound);
            }
        }
    }

    /// <summary>
    /// Gets the direction of each side of a cube
    /// </summary>
    /// <param name="side"></param>
    /// <returns></returns>
    protected Vector3 localDirectionVector3ForSide(int side)
    {
        Vector3 vector;

        switch (side)
        {
            default:
                vector = Vector3.right;
                break;
            case 1:
                vector = Vector3.up;
                break;
            case 2:
                vector = Vector3.forward;
                break;
            case 3:
                vector = Vector3.left;
                break;
            case 4:
                vector = Vector3.down;
                break;
            case 5:
                vector = Vector3.back;
                break;
        }

        return vector;
    }

    /// <summary>
    /// Checks to see if the cube is the same cube as this cube
    /// </summary>
    /// <param name="cube"></param>
    /// <returns></returns>
    private bool isSameCube(GameObject cube)
    {
        if (GameObject.ReferenceEquals(cube, this.gameObject))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Checks to see if a cube is in the same cube system as this one
    /// </summary>
    /// <param name="cube"></param>
    /// <returns></returns>
    private bool isSameCubeSystem(GameObject cube)
    {
        Transform cubeTransform = cube.GetComponent<Transform>();

        if (!cube.TryGetComponent<CubeBehavior>(out CubeBehavior x))
        {
            return false;
        }

        if ((isAnchor && cubeTransform.parent == transform) || (cube.GetComponent<CubeBehavior>().isAnchor && transform.parent == cubeTransform) || cubeTransform.parent == transform.parent)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Checks to see if another cube is near this cube
    /// </summary>
    private void UpdateCubesNextToThisOne()
    {
        for (int i = 0; i < 6; i++)
        {
            cubesNextToThisOne[i] = null;
        }

        for (int i = 0; i < 6; i++)
        {
            Collider[] colliders = Physics.OverlapSphere(transform.TransformPoint(localDirectionVector3ForSide(i) * cubeInformation.cubeScale), .1f);

            foreach (Collider collider in colliders)
            {
                GameObject gameObject = collider.gameObject;

                if (!isSameCube(gameObject) && isSameCubeSystem(gameObject))
                {
                    cubesNextToThisOne[i] = gameObject;
                }
            }
        }
    }

    /// <summary>
    /// Connects this cube to another cube
    /// </summary>
    /// <param name="newCube"></param>
    public virtual void cubeConnect(GameObject newCube)
    {
        CubeBehavior newCubeBehavior = newCube.GetComponent<CubeBehavior>();
        Rigidbody newCubeRigidBody = newCube.GetComponent<Rigidbody>();
        Transform newCubeTransform = newCube.GetComponent<Transform>();

        if (isAnchor)
        {
            newCubeTransform.SetParent(transform);
        }
        else
        {
            newCubeTransform.SetParent(transform.parent);
        }

        newCubeBehavior.isAnchor = false;

        UpdateCubesNextToThisOne();
        newCubeBehavior.UpdateCubesNextToThisOne();
    }

    /// <summary>
    /// Destroys this cube
    /// </summary>
    public virtual void cubeDestroy()
    {
        if (transform.childCount > 0)
        {
            Transform[] childCubesTransform = gameObject.GetComponentsInChildren<Transform>();
            Transform newParentCube = childCubesTransform[1];

            newParentCube.SetParent(null);
            newParentCube.GetComponent<CubeBehavior>().isAnchor = true;

            for (int i = 2; i < childCubesTransform.Length; i++)
            {
                childCubesTransform[i].SetParent(newParentCube);
            }
        }

        for (int i = 0; i < 6; i++)
        {
            if (cubesNextToThisOne[i] != null)
            {
                cubesNextToThisOne[i].GetComponent<CubeBehavior>().UpdateCubesNextToThisOne();
            }
        }

        Destroy(this.gameObject);

        {
            bool[] sidesFound = new bool[6];

            for (int i = 0; i < 6; i++)
            {
                if (sidesFound[i] == true)
                {
                    continue;
                }

                List<GameObject> newCubeSystem = lookForConnectedCubes(i, ref sidesFound);

                if (newCubeSystem.Count == 0)
                {
                    continue;
                }

                newCubeSystem[0].GetComponent<CubeBehavior>().createNewCubeSystem(newCubeSystem);

                sidesFound[i] = true;
            }
        }
    }
}