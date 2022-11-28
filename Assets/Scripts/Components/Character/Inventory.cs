using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    [SerializeField] string inventoryPanelTag, mainCanvasTag;
    [SerializeField] GameObject inventorySlotImageExample, selectedInventorySlotImageExample;
    [SerializeField] int inventorySize = 10;

    PlayerControls playerControls;
    GameObject inventoryPanel;
    GameObject mainCanvas;
    GameObject selectedInventorySlotOverGraphic;
    GameObject selectedInventorySlot = null;

    InventoryItemStack[] inventory;
    int selectedSlot = 1;
    bool selectedSlotChanged = false;

    /// <summary>
    /// Updates selected selected slot based on input
    /// </summary>
    void updateSelectedSlot()
    {
        if (playerControls.Universal.InventorySlotSelect.triggered)
        {
            selectedSlot = (int)Math.Round(playerControls.Universal.InventorySlotSelect.ReadValue<float>());

            selectedSlotChanged = true;
        }
        else if (playerControls.Universal.InventorySlotScroll.triggered)
        {
            float input = playerControls.Universal.InventorySlotScroll.ReadValue<float>();

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
        foreach(Transform child in inventoryPanel.GetComponent<Transform>())
        {
            Destroy(child.gameObject);
        }

        for(int i = 0; i < inventorySize; i++)
        {
            GameObject inventorySlot = Instantiate<GameObject>(inventorySlotImageExample);
            Transform inventorySlotTransform = inventorySlot.GetComponent<Transform>();

            inventorySlotTransform.SetParent(inventoryPanel.GetComponent<Transform>(), false);

            if(i == selectedSlot - 1)
            {
                selectedInventorySlot = inventorySlot;
            }
        }

        selectedInventorySlotOverGraphic.transform.SetParent(mainCanvas.transform, false);
    }

    private void Awake()
    {   
        playerControls = GetComponent<PlayerControlsManager>().playerControls;
        inventoryPanel = GameObject.FindGameObjectWithTag(inventoryPanelTag);
        mainCanvas = GameObject.FindGameObjectWithTag(mainCanvasTag);
        selectedInventorySlotOverGraphic = Instantiate<GameObject>(selectedInventorySlotImageExample);
        
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

        selectedInventorySlotOverGraphic.transform.position = selectedInventorySlot.transform.position;
    }
}
