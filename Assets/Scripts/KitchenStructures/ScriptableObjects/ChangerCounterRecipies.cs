using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChangerCounterRecipies", menuName = "Scriptable Objects/ChangerCounterRecipies")]
public class ChangerCounterRecipies : ScriptableObject // only to make it easy to create and manage the recipes for different types of ChangerCounters.
{
    public string counterType; // the type of the counter, for example: "Oven", "Stove", "Freezer", "Changer"
    public string explanation; //
    public Recipe[] recipes; // to hold the recipes for this counter
    
}
