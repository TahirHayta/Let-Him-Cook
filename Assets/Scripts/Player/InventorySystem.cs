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

    public void AddItem(ItemSO item) {
        if (items.Count >= maxItems) {
            Debug.Log("Inventory is full!");
        }
        items.Add(item);
        Debug.Log("Added " + item.itemName + " to inventory.");
        UpdateInventoryUI();
    }

    public void RemoveItem(ItemSO item) {
        @Assert.IsTrue(items.Contains(item), "Item not found in inventory.");
        items.Remove(item);
        UpdateInventoryUI();
    }

    public void UpdateInventoryUI() {
        foreach (Transform child in inventoryGrid.transform) {
            Destroy(child.gameObject);
        }

        foreach (var item in items) {
            GameObject slot = Instantiate(inventorySlot, inventoryGrid.transform);
            Image icon = slot.GetComponentInChildren<Image>();
            if (icon != null && item.itemPrefab != null) {
                icon.sprite = item.itemPrefab.GetComponent<SpriteRenderer>().sprite;
            }
        }
    }
}
