using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    public List<ItemSO> items = new List<ItemSO>();
    public int maxItems = 10;
    
    public GameObject inventoryGrid;
    public GameObject inventorySlot;
    
    public static Action OnInventoryChanged;

    public bool AddItem(ItemSO item) {
        if (items.Count >= maxItems) {
            Debug.Log("Inventory is full!");
            return false;
        }
        items.Add(item);
        Debug.Log("Added " + item.itemName + " to inventory.");
        UpdateInventoryUI();
        OnInventoryChanged?.Invoke();
        return true;
    }

    public void RemoveItem(ItemSO item) {
        @Assert.IsTrue(items.Contains(item), "Item not found in inventory.");
        items.Remove(item);
        UpdateInventoryUI();
        OnInventoryChanged?.Invoke();
    }

    public void UpdateInventoryUI() {
        foreach (Transform child in inventoryGrid.transform) {
            Destroy(child.gameObject);
        }
        
        GridLayoutGroup grid = inventorySlot.GetComponent<GridLayoutGroup>();
        if (grid != null) {
            grid.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
            grid.constraintCount = maxItems;
        }

        foreach (var item in items) {
            GameObject slot = Instantiate(inventorySlot, inventoryGrid.transform);
            Image icon = slot.GetComponentInChildren<Image>();
            if (icon != null) {
                icon.sprite = item.itemIcon;
            }
        }
        OnInventoryChanged?.Invoke();
    }
    
    public void OnEnable() {
        PlayerInteraction.OnInteract += HandleInventoryChanged;
    }
    public void OnDisable() {
        PlayerInteraction.OnInteract -= HandleInventoryChanged;
    }
    
    private void HandleInventoryChanged(GameObject interactedObject) {
        ItemBehaviour item = interactedObject.GetComponent<ItemBehaviour>();
        if (item != null) {
            bool added = AddItem(item.ItemData);
            if (added) {
                Destroy(interactedObject);
            }
        }
    }
}
