using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemStack
{
    public Inventory inventoryItem { get; private set; }
    public bool isInfinite { get; private set; }

    public int StackSize { get; private set; }

    public InventoryItemStack(Inventory inventoryItemParam, bool isInfiniteParam)
    {
        inventoryItem = inventoryItemParam;
        isInfinite = isInfiniteParam;

        addToStack();
    }

    public void addToStack()
    {
        StackSize++;
    }

    public void removeFromStack()
    {
        StackSize--;
    }
}
