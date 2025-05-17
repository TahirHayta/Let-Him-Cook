using UnityEngine;

public class Material : ItemBehaviour {
    [SerializeField]ItemSO item;
    
    public override void OnPickup() {
        // Logic for when the item is picked up
        Debug.Log("Picked up: " + item.itemName);
        InventorySystem inventory = FindFirstObjectByType<InventorySystem>();
        if (inventory != null) {
            inventory.AddItem(item);
        } else {
            Debug.LogWarning("InventorySystem not found in the scene.");
        }
    }
    
    public override void OnInteract() {
        // ItemBehaviour itemBehaviour = GetComponent<ItemBehaviour>();
        // if (itemBehaviour != null) {
        //     itemBehaviour.OnPickup();
        // }
        // else { Debug.LogWarning("ItemBehaviour component not found on " + this.name);
        // } 
        // Debug.Log(this.name +" has been interacted with!");
    }
    
    public override void OnUse(){}
    public override void OnDrop(){}
    public override void OnEquip(){}
    public override void OnUnequip(){}
}
