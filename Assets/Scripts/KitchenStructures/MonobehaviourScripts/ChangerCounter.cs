using System.Collections;
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
        Recipe recipe = ProcessableRecipe();
        if (recipe == null) return;

        isProcessing = true;
        //TODO devamı kaldı.

    }
    public void stopProcessing() // called if finished or an ingredient is removed.
    {
        isProcessing = false;
        //TODO
    }
    public Recipe ProcessableRecipe()
    {
        for (int i = 0; i < changerCounterRecipies.recipes.Length; i++) // TODO bunu ayrı bir data structure ile daha verimli hale getirebiliriz.
        {
            Recipe recipe = changerCounterRecipies.recipes[i];
            if (recipe.inputItems.Length == currentCapacity)
            {
                bool isValid = true;
                for (int j = 0; j < recipe.inputItems.Length; j++)
                {
                    if (!holdingItems.Contains(recipe.inputItems[j]))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    return recipe;
                }
            }
        }
        return null;
    }
    /*private IEnumerator ProcessRecipe(Recipe recipe)
    {
        yield return new WaitForSeconds(recipe.processTime); //TODO bunu AI yazdı bakmadım daha item e bakmak için
        for (int i = 0; i < recipe.inputItems.Length; i++)
        {
            holdingItems.Remove(recipe.inputItems[i]);
            currentCapacity--;
        }
        holdingItems.AddLast(recipe.outputItem);
        currentCapacity++;
        isFull = currentCapacity >= maxCapacity;
    } */
    


}
