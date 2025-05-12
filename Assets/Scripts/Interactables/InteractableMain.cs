using Unity.VisualScripting;
using UnityEngine;

// father class of interactables **********
public class InteractableMain : MonoBehaviour, InteractableInterface 
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact() // called from PlayerInteraction.cs
    {
        Debug.Log(this.name +" has been interacted with!");
    }
}
