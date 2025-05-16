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
    public LinkedList<FoodItem> foodItems = new LinkedList<FoodItem>(); // to hold food items in the counter
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initalizeEmptyCounter(); // For now
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void initalizeEmptyCounter()
    {
        isFull = false;
        currentCapacity = 0;
        foodItems.Clear();
    }
    public void initalizeFromData(StructureData data)
    {
        
    }

    public void Interact() // called from PlayerInteraction.cs
    {
        Debug.Log(this.name + " has been interacted with!");
    }
    public virtual void AddItem(FoodItem item)
    {

    }
    public virtual void GetItem(FoodItem item)
    {

    }
    
}
