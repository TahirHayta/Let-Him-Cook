using System.Collections.Generic;
using UnityEngine;

public class ChangerCounter : CounterParent
{
    public ChangerCounterRecipies changerCounterRecipies; // to convert some food items to another food item, we will check this counter's recipes.
    public bool isProcessing; // if this counter is processing a recipe, we will not allow to add more items to it.
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void startProcessing() // Everytime will be called when a food item is added to this counter.
    {
        if (isProccessable())
        {
            isProcessing = true;
        }

    }
    public void stopProcessing() // called if finished or an ingredient is removed.
    {
        isProcessing = false;
    }
    public bool isProccessable() // TODO check recipe with this.fooditems.
    {
        return false; 
    }


}
