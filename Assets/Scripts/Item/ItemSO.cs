using UnityEngine;

[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Objects/Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public int itemID;
    public string itemDescription;
    public Sprite itemIcon;
    public GameObject itemPrefab; // bunu çıkartabiliriz de ben de tam bilmiyom
}
