using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCubeBehavior : CubeBehavior
{
    [HideInInspector] public bool physicsEnabled = true;

    protected override void createNewCubeSystem(List<GameObject> cubes)
    {
        base.createNewCubeSystem(cubes);

        {
            bool solidCubeFound = false;

            foreach (GameObject cube in cubes)
            {

                if (cube.TryGetComponent<StaticCubeBehavior>(out StaticCubeBehavior y))
                {
                    solidCubeFound = true;
                }

                if (solidCubeFound == true)
                {
                    goto afterForEach;
                }
            }
            afterForEach:

            if (solidCubeFound)
            {
                foreach (GameObject cube in cubes)
                {
                    TryGetComponent<PhysicsCubeBehavior>(out PhysicsCubeBehavior physicsCubeBehavior);
                    physicsCubeBehavior.physicsEnabled = false;
                }

                return;
            }
        }

        if(!TryGetComponent<Rigidbody>(out Rigidbody x))
        {
            gameObject.AddComponent<Rigidbody>();
        }

        if (cubes.Count > 1)
        {
            for (int i = 1; i < cubes.Count; i++)
            {
                Destroy(cubes[i].GetComponent<Rigidbody>());
            }
        }

        updateMass();
    }

    public override void cubeConnect(GameObject newCube)
    {
        base.cubeConnect(newCube);
        
        if(transform.parent == null && physicsEnabled)
        {
            updateMass();
        }
        else
        {
            if (physicsEnabled)
            {
                transform.parent.GetComponent<PhysicsCubeBehavior>().updateMass();
            }

            Destroy(newCube.GetComponent<Rigidbody>());
            newCube.GetComponent<PhysicsCubeBehavior>().physicsEnabled = false;
        }
    }

    /// <summary>
    /// Updates mass of this cube
    /// </summary>
    private void updateMass()
    {
        if (isAnchor == true)
        {
            GetComponent<Rigidbody>().mass = transform.childCount + 1;
        }
    }
}
