using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    [SerializeField] string inventoryPanelTag;
    [SerializeField] GameObject inventorySlotImageExample, selectedInventorySlotImageExample;
    [SerializeField] int inventorySize = 10;

    PlayerControls playerControls;
    GameObject inventoryPanel;
    InventoryItemStack[] inventory;
    int selectedSlot = 1;
    bool selectedSlotChanged = false;

    /// <summary>
    /// Updates selected selected slot based on input
    /// </summary>
    void updateSelectedSlot()
    {
        if (playerControls.Player.InventorySlotSelect.triggered)
        {
            selectedSlot = (int)Math.Round(playerControls.Player.InventorySlotSelect.ReadValue<float>());

            selectedSlotChanged = true;
        }
        else if (playerControls.Player.InventorySlotScroll.triggered)
        {
            float input = playerControls.Player.InventorySlotScroll.ReadValue<float>();

            if (input > 0)
            {
                if(selectedSlot == 1)
                {
                    selectedSlot = inventorySize;
                }
                else
                {
                    selectedSlot -= 1;
                }
            }
            else if(input < 0)
            {
                if (selectedSlot == inventorySize)
                {
                    selectedSlot = 1;
                }
                else
                {
                    selectedSlot += 1;
                }
            }

            selectedSlotChanged = true;
        }
        else
        {
            selectedSlotChanged = false;
        }
    }

    /// <summary>
    /// Instantiates inventory graphics
    /// </summary>
    void updateInventoryGraphics()
    {


        void instantiateGameObjects(int i)
        {
            GameObject inventorySlot;
            Transform inventorySlotTransform;

            if(i == selectedSlot)
            {
                inventorySlot = Instantiate<GameObject>(selectedInventorySlotImageExample);
            }
            else
            {
                inventorySlot = Instantiate<GameObject>(inventorySlotImageExample);
            }

            inventorySlotTransform = inventorySlot.GetComponent<Transform>();

            inventorySlotTransform.SetParent(inventoryPanel.GetComponent<Transform>());

            if (inventory[i] != null)
            {
                GameObject Icon = Instantiate<GameObject>(inventory[i].inventoryItem.inventorySlotImageExample);

                Icon.GetComponent<Transform>().SetParent(inventorySlotTransform);
            }
        }

        foreach(Transform child in inventoryPanel.GetComponent<Transform>())
        {
            Destroy(child.gameObject);
        }

        for(int i = 1; i <= inventorySize; i++)
        {
            instantiateGameObjects(i);
        }
    }

    private void Awake()
    {
        playerControls = GetComponent<PlayerControlsManager>().playerControls;
        inventoryPanel = GameObject.FindGameObjectWithTag(inventoryPanelTag);
        
        inventory = new InventoryItemStack[inventorySize];
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
        updateSelectedSlot();

        if (selectedSlotChanged)
        {
            updateInventoryGraphics();
        }

        print(selectedSlot);
    }
}
