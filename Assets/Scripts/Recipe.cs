using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "Scriptable Objects/Recipe")]
public class Recipe : ScriptableObject
{
    public string recipeName;
    public FoodItem[] inputItems; // the food items that are needed to create this recipe
    public FoodItem outputItem; // the food item that will be created from the input items
    public float processTime; // the time it takes to cook/prepare this recipe    
}
