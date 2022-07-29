using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private int inventorySize = 10;

    /// <summary>
    /// Sets up inventory
    /// </summary>
    private void setUpInventory()
    {
        void setUpTexture()
        {
            if ((inventorySize % 2) == 0)
            {

            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        setUpInventory();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
