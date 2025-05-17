using System.Collections.Generic;
using UnityEngine;

public class CounterParent : MonoBehaviour, InteractableInterface
{
    public StructureData structureData;
    public string counterName;
    public Vector3 position;
    public bool isFull;
    public int maxCapacity;
    public int currentCapacity;
    public LinkedList<ItemSO> ItemSOs = new LinkedList<ItemSO>(); // to hold food items in the counter
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartToTry();
    }
    private void StartToTry() // to test
    {
        // Should I initialize from StructureData? or should I create StructureData from here?
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Interact() // called from PlayerInteraction.cs
    {
        Debug.Log(this.name + " has been interacted with!");
    }
    public virtual void AddItem(ItemSO item)
    {
        if (!isFull)
        {
            ItemSOs.AddLast(item);
            currentCapacity++;
            if (currentCapacity >= maxCapacity)
            {
                isFull = true;
            }
            Debug.Log(item.itemName + " has been added to " + counterName);
        }
        else
        {
            Debug.Log(counterName + " is full!");
        }
    }
    public virtual ItemSO GetItem()
    {
        if (currentCapacity > 0)
        {
            ItemSO item = ItemSOs.Last.Value;
            ItemSOs.RemoveLast();
            currentCapacity--;
            isFull = false;
            return item;
        }
        else
        {
            Debug.Log(counterName + " is empty!");
            return null;
        }
    }
    
}
