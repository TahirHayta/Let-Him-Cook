using UnityEngine;

public abstract class ItemBehaviour : MonoBehaviour{
    
    public ItemSO ItemData;
    // I just binge added this possible calls. Don't know if they'll all have a use.
    public abstract void OnPickup();
    public abstract void OnUse();
    public abstract void OnDrop();
    public abstract void OnEquip();
    public abstract void OnUnequip();
    public abstract void OnInteract();
}
