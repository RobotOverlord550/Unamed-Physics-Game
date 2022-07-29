using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] string inventoryPanelTag;
    [SerializeField] GameObject inventorySlotImageExample;
    [SerializeField] int inventorySize = 10;

    GameObject inventoryPanel;
    Inventory[] inventory;
    int selectedSlot = 0;
    bool selectedSlotChanged = false;

    /// <summary>
    /// Updates the selected slot of the inventory based on player input
    /// </summary>
    void updateSelectedSlot()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            selectedSlot = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedSlot = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedSlot = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedSlot = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            selectedSlot = 4;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            selectedSlot = 5;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            selectedSlot = 6;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            selectedSlot = 7;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            selectedSlot = 8;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            selectedSlot = 9;
        }
        else
        {
            return;
        }

        selectedSlotChanged = true;
    }

    /// <summary>
    /// Instantiates inventory graphics and data
    /// </summary>
    void updateInventoryGraphics()
    {
        inventoryPanel = GameObject.FindGameObjectWithTag(inventoryPanelTag);

        inventory = new Inventory[inventorySize];

        for(int i = 1; i <= inventorySize; i++)
        {
            GameObject inventroySlot = Instantiate<GameObject>(inventorySlotImageExample);

            inventroySlot.GetComponent<Transform>().parent = inventoryPanel.GetComponent<Transform>();
        }
    }

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        updateInventoryGraphics();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        if (selectedSlotChanged)
        {
            updateInventoryGraphics();
        }
    }
}
