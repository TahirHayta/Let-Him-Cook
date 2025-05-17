using System;
using UnityEngine;

public class Material : ItemBehaviour
{
    //[SerializeField] ItemSO item; // bu zaten ItemBehaviour'da vardı ItemData olarak. buradaki item ler yerine ItemData yazdım.
    public static Action<ItemSO,GameObject> OnItemAdded; // For event-based system
    public override void OnPickup()
    {
        // Logic for when the item is picked up
        Debug.Log("Picked up: " + ItemData.itemName);
        OnItemAdded?.Invoke(ItemData,gameObject); // InventorySystem.cs will handle this.

    }

    public override void Interact()
    {
        if (true) // Hangi şartta OnPickup() çağrılacak? bu arada OnInteract() metoduyla aynı amaç muhtemelen de belki farklı bir amacın vardır diye silmedim onu.
        {
            OnPickup();
        }
    }
    /*public override void OnInteract()
    {
        // ItemBehaviour itemBehaviour = GetComponent<ItemBehaviour>();
        // if (itemBehaviour != null) {
        //     itemBehaviour.OnPickup();
        // }
        // else { Debug.LogWarning("ItemBehaviour component not found on " + this.name);
        // } 
        // Debug.Log(this.name +" has been interacted with!");
    }*/

    public override void OnUse() { }
    public override void OnDrop() { }
    public override void OnEquip() { }
    public override void OnUnequip() { }

}
