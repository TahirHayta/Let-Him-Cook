using UnityEngine;

[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Objects/Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public GameObject itemPrefab;
}
