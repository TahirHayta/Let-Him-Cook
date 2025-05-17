using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChangerCounterRecipies", menuName = "Scriptable Objects/ChangerCounterRecipies")]
public class ChangerCounterRecipies : ScriptableObject
{
    public string counterType; // the type of the counter, for example: "Oven", "Stove", "Freezer", "Changer"
    public LinkedList<Recipe> recipes; // to hold the recipes for this counter
    
}
