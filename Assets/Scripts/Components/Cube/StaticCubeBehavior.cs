using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCubeBehavior : CubeBehavior
{
    public override void cubeConnect(GameObject newCube)
    {
        base.cubeConnect(newCube);

        if(newCube.TryGetComponent<PhysicsCubeBehavior>(out PhysicsCubeBehavior physicsCubeBehavior))
        {
            physicsCubeBehavior.physicsEnabled = false;
            Destroy(newCube.GetComponent<Rigidbody>());
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
